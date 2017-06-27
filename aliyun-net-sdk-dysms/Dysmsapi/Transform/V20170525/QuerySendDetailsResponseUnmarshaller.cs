/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dysmsapi.Model.V20170525;
using System.Collections.Generic;

namespace Aliyun.Acs.Dysmsapi.Transform.V20170525
{
    public class QuerySendDetailsResponseUnmarshaller
    {
        public static QuerySendDetailsResponse Unmarshall(UnmarshallerContext context)
        {
            List<SmsSendDetailDTO> SendDetailDTOs = new List<SmsSendDetailDTO>();
            for (int i = 0; i < context.Length("QuerySendDetails.SmsSendDetailDTOs.Length"); i++)
            {
                SmsSendDetailDTO sendDetailDTO = new SmsSendDetailDTO()
                {
                    Content = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].Content"),
                    ErrCode = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].ErrCode"),
                    OutId = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].OutId"),
                    PhoneNum = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].PhoneNum"),
                    ReceiveDate = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].ReceiveDate"),
                    SendDate = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].SendDate"),
                    SendStatus = context.LongValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].SendStatus"),
                    TemplateCode = context.StringValue("QuerySendDetails.SmsSendDetailDTOs[" + i + "].TemplateCode")
                };
                SendDetailDTOs.Add(sendDetailDTO);
            }
            return new QuerySendDetailsResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QuerySendDetails.RequestId"),
                Code = context.StringValue("QuerySendDetails.Code"),
                Message = context.StringValue("QuerySendDetails.Message"),
                TotalCount = context.IntegerValue("QuerySendDetails.TotalCount"),
                TotalPage = context.IntegerValue("QuerySendDetails.TotalPage"),
                SmsSendDetailDTOs = SendDetailDTOs
            };
        }
    }
}
