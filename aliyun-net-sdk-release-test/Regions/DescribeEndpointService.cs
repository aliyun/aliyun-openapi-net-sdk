using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Exceptions;

namespace Aliyun.Acs.Core.Regions
{
    class DescribeEndpointService
    {
        private static String DEFAULT_ENDPOINT_TYPE = "openAPI";

        private ISigner signer = new ShaHmac1();

        private bool isEmpty(String str)
        {
            return ((str == null) || (str.Length == 0));
        }

        public DescribeEndpointResponse DescribeEndpoint(String regionId, String locationProduct,
                                                         Credential credential, LocationConfig locationConfig)
        {
            if (isEmpty(locationProduct))
            {
                return null;
            }

            DescribeEndpointRequest request = new DescribeEndpointRequest();
            request.AcceptFormat = FormatType.JSON;
            request.Id = regionId;
            request.RegionId = locationConfig.RegionId;
            request.LocationProduct = locationProduct;
            request.EndpointType = DEFAULT_ENDPOINT_TYPE;

            ProductDomain domain = new ProductDomain(locationConfig.Product, locationConfig.Endpoint);

            try
            {
                HttpRequest httpRequest = request.SignRequest(signer, credential, FormatType.JSON, domain);
                HttpResponse httpResponse = HttpResponse.GetResponse(httpRequest);
                if (httpResponse.isSuccess())
                {
                    String data = System.Text.Encoding.UTF8.GetString(httpResponse.Content);
                    DescribeEndpointResponse response = getEndpointResponse(data, DEFAULT_ENDPOINT_TYPE);
                    if (null == response || isEmpty(response.Endpoint))
                    {
                        return null;
                    }
                    return response;
                }
                AcsError error = readError(httpResponse, FormatType.JSON);
                if (500 <= httpResponse.Status)
                {
                    Console.WriteLine("Invoke_Error, requestId:" + error.RequestId + "; code:" + error.ErrorCode
                            + "; Msg" + error.ErrorMessage);
                    return null;
                }
                Console.WriteLine("Invoke_Error, requestId:" + error.RequestId + "; code:" + error.ErrorCode
                        + "; Msg" + error.ErrorMessage);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invoke Remote Error,Msg" + e.Message);
                return null;
            }
        }

        private DescribeEndpointResponse getEndpointResponse(String data, String endpointType)
        {
            IReader reader = ReaderFactory.CreateInstance(FormatType.JSON);
            UnmarshallerContext context = new UnmarshallerContext();

            context.ResponseDictionary = reader.Read(data, "DescribeEndpointsResponse");

            int endpointsLength = context.Length("DescribeEndpointsResponse.Endpoints.Length");
            for (int i = 0; i < endpointsLength; i++)
            {
                if (endpointType.Equals(context
                        .StringValue("DescribeEndpointsResponse.Endpoints[" + i + "].Type")))
                {
                    DescribeEndpointResponse response = new DescribeEndpointResponse();

                    response.RequestId = context.StringValue("DescribeEndpointsResponse.RequestId");
                    response.Product = context.StringValue("DescribeEndpointsResponse.Endpoints[" + i + "].SerivceCode");
                    response.Endpoint = context.StringValue("DescribeEndpointsResponse.Endpoints[" + i + "].Endpoint");
                    response.RegionId = context.StringValue("DescribeEndpointsResponse.Endpoints[" + i + "].Id");
                    return response;
                }
            }
            return null;
        }

        private AcsError readError(HttpResponse httpResponse, FormatType format)
        {
            String responseEndpoint = "Error";
            IReader reader = ReaderFactory.CreateInstance(format);
            UnmarshallerContext context = new UnmarshallerContext();
            String stringContent = getResponseContent(httpResponse);
            context.ResponseDictionary = reader.Read(stringContent, responseEndpoint);

            return AcsErrorUnmarshaller.Unmarshall(context);
        }

        private String getResponseContent(HttpResponse httpResponse)
        {
            String stringContent = null;
            try
            {
                if (null == httpResponse.Encoding)
                {
                    stringContent = System.Text.Encoding.Default.GetString(httpResponse.Content);
                }
                else
                {
                    stringContent = System.Text.Encoding.GetEncoding(httpResponse.Encoding).GetString(httpResponse.Content);
                }
            }
            catch (Exception exp)
            {
                throw new ClientException("SDK.UnsupportedEncoding", "Can not parse response due to un supported encoding.");
            }
            return stringContent;
        }
    }
}
