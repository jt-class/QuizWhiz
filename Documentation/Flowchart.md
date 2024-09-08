QuizWhiz Flowchart:

```mermaid
graph TD;
    LaunchApp-->LogIn/SignUp;
    LogIn/SignUp-->HomePage;
    HomePage-->CreateQuiz;
    HomePage-->TakeQuiz;
    TakeQuiz-->QuizResults;
    QuizResults-->Finish;
    Finish-->HomePage;
    CreateQuiz-->FillUpForm;
    FillUpForm-->Publish;
    Publish-->Finish;
```
