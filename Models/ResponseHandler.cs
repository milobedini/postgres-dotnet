namespace postgres_dotnet.Models;

public class ResponseHandler
{
    public static APIResponse GetExceptionResponse(Exception ex)
    {
        APIResponse response = new APIResponse();
        response.Code = "1";
        response.ResponseData = ex.Message;
        return response;
    }

    public static APIResponse GetAppResponse(ResponseType type, object? data)
    {
        APIResponse response;

        response = new APIResponse { ResponseData = data };
        switch (type)
        {
            case ResponseType.Success:
                response.Code = "0";
                response.Message = "Success";
                break;

            case ResponseType.NotFound:
                response.Code = "2";
                response.Message = "No record available";
                break;
        }
        return response;
    }
}