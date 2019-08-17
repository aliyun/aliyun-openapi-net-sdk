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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dysmsapi.Model.V20170525;

namespace Aliyun.Acs.Dysmsapi.Transform.V20170525
{
    public class QuerySendDetailsResponseUnmarshaller
    {
        public static QuerySendDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySendDetailsResponse querySendDetailsResponse = new QuerySendDetailsResponse();

			querySendDetailsResponse.HttpResponse = context.HttpResponse;
			querySendDetailsResponse.RequestId = context.StringValue("QuerySendDetails.RequestId");
			querySendDetailsResponse.Code = context.StringValue("QuerySendDetails.Code");
			querySendDetailsResponse.Message = context.StringValue("QuerySendDetails.Message");
			querySendDetailsResponse.TotalCount = context.StringValue("QuerySendDetails.TotalCount");

			List<QuerySendDetailsResponse.QuerySendDetails_SmsSendDetailDTO> querySendDetailsResponse_smsSendDetailDTOs = new List<QuerySendDetailsResponse.QuerySendDetails_SmsSendDetailDTO>();
			for (int i = 0; i < context.Length("QuerySendDetails.SmsSendDetailDTOs.Length"); i++) {
				QuerySendDetailsResponse.QuerySendDetails_SmsSendDetailDTO smsSendDetailDTO = new QuerySendDetailsResponse.QuerySendDetails_SmsSendDetailDTO();
				smsSendDetailDTO.PhoneNum = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].PhoneNum");
				smsSendDetailDTO.SendStatus = context.LongValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].SendStatus");
				smsSendDetailDTO.ErrCode = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].ErrCode");
				smsSendDetailDTO.TemplateCode = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].TemplateCode");
				smsSendDetailDTO.Content = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].Content");
				smsSendDetailDTO.SendDate = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].SendDate");
				smsSendDetailDTO.ReceiveDate = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].ReceiveDate");
				smsSendDetailDTO.OutId = context.StringValue("QuerySendDetails.SmsSendDetailDTOs["+ i +"].OutId");

				querySendDetailsResponse_smsSendDetailDTOs.Add(smsSendDetailDTO);
			}
			querySendDetailsResponse.SmsSendDetailDTOs = querySendDetailsResponse_smsSendDetailDTOs;
        
			return querySendDetailsResponse;
        }
    }
}
