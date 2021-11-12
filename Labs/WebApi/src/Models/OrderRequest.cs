using System.Collections.Generic;

namespace ApiGateway.Models

{
public class OrderRequest {


    public int CustomerId {get; set;}
    public int  OrderId {get; set;}
    public int PaymentId {get; set;}
    public double Total {get; set;}
    public List<string> orderItems {get; set;}






}

}