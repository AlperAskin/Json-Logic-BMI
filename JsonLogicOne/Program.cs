// See https://aka.ms/new-console-template for more information
using JsonLogic.Net;
using Newtonsoft.Json.Linq;
using System.Text.Json;

var user = @"{
    'age': '25',
    'weight': '70',
    'height' : '1.83',
}";
var rule = @"{
        '/':[
        {'var':'weight'},
        {
         '*': [
        {'var':'height'},
        {'var':'height'}
        ]}
]
}";

JToken jt = JToken.Parse(rule);
JToken jt2 = JToken.Parse(user);

JsonLogicEvaluator jsonLogic = new JsonLogicEvaluator(EvaluateOperators.Default);
Object result = jsonLogic.Apply(jt, jt2);

Console.WriteLine("Your BMI: "+ result);