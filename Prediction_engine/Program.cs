using System;
using System.IO;
using Prediction_engine;


Console.WriteLine("The following program classifies \nthe comments of differents restaurants\n");
int x = 1;
while (x >= 0) {
    //Load sample data
    var sampleData = new MLModelSentID.ModelInput()
    {
        Col0 = Console.ReadLine(),
    };

    //Load model and predict output
    var result = MLModelSentID.Predict(sampleData);
    if (result.PredictedLabel > 0) Console.WriteLine("Thats good\n");
    else Console.WriteLine("disgusting place\n");
    x--;
    Console.WriteLine("press enter to continue\n");
    Console.ReadLine();
}