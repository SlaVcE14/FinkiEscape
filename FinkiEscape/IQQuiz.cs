using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace FinkiEscape
{
    public partial class IQQuiz : Form
    {
        List<Question> allQuestions = new List<Question>();
        List<Question> questions = new List<Question>();
        
        int id = -1;
        int numQestions = 10;
        int numCorrect = 0;
        int numCorrectToPass = 5;

        Question currentQuestion;

        private System.Timers.Timer timer;
        
        public IQQuiz()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            init();
            timer = new System.Timers.Timer(800);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = false;
            nextQuestion();
        }
        
        private void nextQuestion()
        {
            
            id++;

            if (id >= questions.Count)
            {
                endGame();
                return;
            }
                

            counter.Text = String.Format("{0}/{1}, точни: {2}", id + 1, numQestions,numCorrect);
            
            currentQuestion = questions[id];

            questionTxt.Text = currentQuestion.question;

            answer1.Text = currentQuestion.answers[0];
            answer2.Text = currentQuestion.answers[1];
            answer3.Text = currentQuestion.answers[2];
            answer4.Text = currentQuestion.answers[3];

            ResetButtonColors();

        }

        
        private void guess(int answer, Button selectedAnswer)
        {
            List<Button> buttons = new List<Button>() { answer1,answer2,answer3,answer4};

            if (questions[id].correct == answer)
            {
                numCorrect++;
                selectedAnswer.BackColor = Color.Green;
            }
            else
            {
                selectedAnswer.BackColor = Color.Red;
            }

            answer1.Enabled = false;
            answer2.Enabled = false;
            answer3.Enabled = false;
            answer4.Enabled = false;

            timer.Start();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                nextQuestion();
            });
        }

        private void ResetButtonColors()
        {
            answer1.BackColor = SystemColors.Control;
            answer2.BackColor = SystemColors.Control;
            answer3.BackColor = SystemColors.Control;
            answer4.BackColor = SystemColors.Control;

            answer1.Enabled = true;
            answer2.Enabled = true;
            answer3.Enabled = true;
            answer4.Enabled = true;
        }


        private void endGame()
        {
            bool isPass = numCorrect >= numCorrectToPass;

            MessageBox.Show(String.Format("Одговоривте точно на {0} од {1} прашања. {2}", numCorrect, numQestions, isPass?"Ја завршивте овва игра":"Не го поминавте квизот!"),"IQ Квиз",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.DialogResult = isPass? DialogResult.OK : DialogResult.Cancel;
        }

        
        private void init()
        {
            addQuestion("Кој број логички следува\n2, 5, 8, 11, ?", "8", "12", "14", "16",2);
            addQuestion("Кој број логички следува\n2, 4, 8, 16, ?", "12", "32", "64", "128",1);
            addQuestion("Кој е бројот што недостасува?\n2, 4, 6, 8, ?", "9", "12", "7", "10", 3);
            addQuestion("Кој е бројот што недостасува?\n10, 20, 30, ?, 50", "40", "45", "35", "49", 0);
            addQuestion("Колку континенти има на Земјата?", "20", "7", "15", "50",1);
            addQuestion("Кој беше првиот човек на Месечината?", "Ленс Армстронг", "Џорџ Вашингтон", "Нил Армстронг", "Јас", 2);
            addQuestion("Колку месеци во годината имаат само 29 дена?", "1", "3", "4", "1, но не секоја година, туку еднаш на секои 4 години", 3);
            addQuestion("Која е вредноста на кој било број помножен со нула?", "0", "Истиот број", "1", "Недефинирано", 0);
            addQuestion("Колку нули има во 1 милион?", "6", "5", "3", "4", 0);
            addQuestion("Каде се наоѓа зградата на ФИНКИ?", "до ФЕИТ", "до ТМФ", "до Педагошки", "не постои", 3);
            addQuestion("Бинарно собирање:\n101001 + 1", "101000", "101010", "101001", "1010110", 1);
            addQuestion("Бинарно одземање:\n101001 - 1", "100000", "101000", "101001", "10100", 1);

            getQuestions();

        }

        private void addQuestion(string q, string a1, string a2, string a3, string a4,int c)
        {
            allQuestions.Add(new Question(q, c, a1, a2, a3, a4));
        }

        private void getQuestions()
        {
            Random r = new Random();

            for (int i = 0; i < numQestions; i++)
            {
                int id = r.Next(allQuestions.Count);

                questions.Add(allQuestions[id]);
                allQuestions.RemoveAt(id);

            }

        }

        private void answer1_Click(object sender, EventArgs e)
        {
            guess(0, answer1);
            
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            guess(1, answer2);
            
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            guess(2, answer3);
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            guess(3, answer4);
        }
    }
   
    class Question
    {

        public string question { get;}
        public string[] answers { get;}
        public int correct { get;}

        public Question(string question,int correct, params string[] answers)
        {
            this.question = question;
            this.correct = correct;
            this.answers = answers;
        }
    }
}
