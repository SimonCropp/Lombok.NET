using System.Net;
using Xunit;

namespace Lombok.NET.Test;

public class DecoratorTest
{
	[Fact]
	public Task BeverageTest()
	{
		const string source = """
		                      using Lombok.NET;
		                      
		                      namespace Test;
		                      
		                      [Decorator]
		                      public abstract class Beverage
		                      {
		                      	  public abstract double GetPrice();
		                      }
		                      """;

		return TestHelper.Verify<DecoratorGenerator>(source);
	}

	[Fact]
	public Task VehicleTest()
	{
		const string source = """
		                      using System.Net;
		                      using Lombok.NET;
		                      
		                      namespace Test;
		                      
		                      [Decorator]
		                      interface IVehicle
		                      {
		                      	  void Drive();
		                      	  
		                      	  int GetNumberOfWheels();
		                      
		                      	  HttpStatusCode GetStatusCode();
		                      }
		                      """;

		return TestHelper.Verify<DecoratorGenerator>(source);
	}

	[Fact]
	public Task MathOperationTest()
	{
		const string source = """
		                      using Lombok.NET;
		                      
		                      namespace Test;
		                      
		                      [Decorator]
		                      public interface IMathOperation
		                      {
		                      	  int Execute(int val);
		                      }
		                      """;

		return TestHelper.Verify<DecoratorGenerator>(source);
	}
}