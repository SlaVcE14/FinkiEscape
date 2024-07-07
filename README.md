![game logo](images/logo.png)
# FinkiEscape

## Опис на играта
...

## Структура на проектот
...

## Објаснубање на класата [ConnectWires](FinkiEscapa/ConnectWires.cs)
се чуваат во `Rectangle` променливи за позициите на почетната и крајната областа на жиците каде што може да се кликне со гчувчето
```c#
//Strat
static Rectangle r1Area = new Rectangle(118, 93, 15, 15);
static Rectangle b1Area = new Rectangle(118, 168, 15, 15);
tatic Rectangle y1Area = new Rectangle(118, 243, 15, 15);
//End
static Rectangle b2Area = new Rectangle(466, 93, 15, 15);
static Rectangle y2Area = new Rectangle(466, 168, 15, 15);
static Rectangle r2Area = new Rectangle(466, 243, 15, 15);

List<Rectangle> rectangles = new List<Rectangle>{ r1Area, b1Area, y1Area, r2Area, b2Area, y2Area};
```
исто така се чива и бојата со која треба да се обојат жиците
```c#
Color[] colors = { Color.FromArgb(224, 27, 34), Color.FromArgb(0, 114, 188), Color.FromArgb(225, 199, 26) };
```

### MouseDown
Со клил на формата се проверува дали е запичнато поврзувањето на жиците (`connectingWiresStarted == true`). Ако не е, се проверува дали позицијата на глувчето е во почетната областа каде што треба да почне поврзувањето на жицата (`isStartPos(rect)`). Аке тој услов е задоволен се проверува на која облас е кликнато и според тоа се одлучува која боја да биде жицата и се одредува таргет позицијата каде што треба да заврши жицата и се означива дека е започнато поврзувањето на жиците. Ако е запичнато поврзувањето на жиците, се проверува дали локацијата на глувчето е во крајноте области (`isEndPos(rect)`). Ако е, се проверува дали е точната крајна позиција кликната. ако и тој услов е исполнет се означива дека таа жица е поврзана и се означува дека повеч не се поврзува жица.
```c#
private void ConnectWires_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rect = isOnTarget(e.Location);

            if (!connectingWiresStarted && isStartPos(rect))
            {
                currentIndex = rectangles.IndexOf(rect);

                if (drawnLine[currentIndex])
                    return;

                connectingWiresStarted = true;

                points[0] = rect.Location;
                points[0].Offset(7, 7);

                return;
            }

            if (isEndPos(rect) && rect == rectangles[currentIndex + 3])
            {
                drawnLine[currentIndex] = true;
                connectingWiresStarted = false;
                isFinished();
            }

        }
```
ако сите жици се поврзани се враќа `DialogResult.OK`
```c#
private void isFinished()
        {
            if(drawnLine[0] && drawnLine[1] && drawnLine[2])
            {
                DialogResult = DialogResult.OK;
            }
        }
```


### MouseMove 
во MouseMove методата се проверува дали локацијата на глувчето е во некоја областа. Ако е, се менува курсорот на глувчето во `Cursors.Hand`
```c#
private void ConnectWires_MouseMove(object sender, MouseEventArgs e)
        {

            if (isOnTarget(e.Location) != Rectangle.Empty)
            {
                Cursor.Current = Cursors.Hand;
                
            }else Cursor.Current = Cursors.Default;
            
            points[1] = e.Location;

        }
```
### Paint

во Paint методата се проверува дали некоја жица е поврзана. Ако е, се црта таа жица на формата
```c#
private void ConnectWires_Paint(object sender, PaintEventArgs e)
        {

            if (drawnLine[0])
            {
                e.Graphics.DrawLine(new Pen(colors[0], 15), lines[0][0], lines[0][1]);
            }
            if (drawnLine[1])
            {
                e.Graphics.DrawLine(new Pen(colors[1], 15), lines[1][0], lines[1][1]);
            }
            if (drawnLine[2])
            {
                e.Graphics.DrawLine(new Pen(colors[2], 15), lines[2][0], lines[2][1]);
            }

            if (connectingWiresStarted)
                e.Graphics.DrawLine(new Pen(colors[currentIndex],15), points[0], points[1]);

            Invalidate();

        }
```
Ако поврзувањето на жици е започнато, се црта и таа жиза

## Screenshots
