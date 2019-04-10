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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class SenderStatisticsDetailByParamResponseUnmarshaller
    {
        public static SenderStatisticsDetailByParamResponse Unmarshall(UnmarshallerContext context)
        {
			SenderStatisticsDetailByParamResponse senderStatisticsDetailByParamResponse = new SenderStatisticsDetailByParamResponse();

			senderStatisticsDetailByParamResponse.HttpResponse = context.HttpResponse;
			senderStatisticsDetailByParamResponse.RequestId = context.StringValue("SenderStatisticsDetailByParam.RequestId");
			senderStatisticsDetailByParamResponse.NextStart = context.IntegerValue("SenderStatisticsDetailByParam.NextStart");

			List<SenderStatisticsDetailByParamResponse.SenderStatisticsDetailByParam_MailDetail> senderStatisticsDetailByParamResponse_data = new List<SenderStatisticsDetailByParamResponse.SenderStatisticsDetailByParam_MailDetail>();
			for (int i = 0; i < context.Length("SenderStatisticsDetailByParam.Data.Length"); i++) {
				SenderStatisticsDetailByParamResponse.SenderStatisticsDetailByParam_MailDetail mailDetail = new SenderStatisticsDetailByParamResponse.SenderStatisticsDetailByParam_MailDetail();
				mailDetail.LastUpdateTime = context.StringValue("SenderStatisticsDetailByParam.Data["+ i +"].LastUpdateTime");
				mailDetail.UtcLastUpdateTime = context.StringValue("SenderStatisticsDetailByParam.Data["+ i +"].UtcLastUpdateTime");
				mailDetail.AccountName = context.StringValue("SenderStatisticsDetailByParam.Data["+ i +"].AccountName");
				mailDetail.ToAddress = context.StringValue("SenderStatisticsDetailByParam.Data["+ i +"].ToAddress");
				mailDetail.Status = context.IntegerValue("SenderStatisticsDetailByParam.Data["+ i +"].Status");
				mailDetail.Message = context.StringValue("SenderStatisticsDetailByParam.Data["+ i +"].Message");

				senderStatisticsDetailByParamResponse_data.Add(mailDetail);
			}
			senderStatisticsDetailByParamResponse.Data = senderStatisticsDetailByParamResponse_data;
        
			return senderStatisticsDetailByParamResponse;
        }
    }
}
