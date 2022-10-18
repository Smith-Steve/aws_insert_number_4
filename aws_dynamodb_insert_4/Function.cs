using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace aws_dynamodb_insert_4;

public class Function
{

	/// <summary>
	/// A simple function that takes a string and does a ToUpper
	/// </summary>
	/// <param name="input"></param>
	/// <param name="context"></param>
	/// <returns></returns>
	public string FunctionHandler(string input, ILambdaContext context)
    {
		AmazonDynamoDBClient client = new AmazonDynamoDBClient();
		string tableName = "ProductCatalog";
		var request = new PutItemRequest
		{
			TableName = tableName;
			Item = new Dictionary<string, AttributeValue>();
			{
				{ "Phone_Number", new AttributeValue { N = "6107615601" }}; 
			}
		};


		return input.ToUpper();
    }
}
