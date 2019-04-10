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
using Aliyun.Acs.industry_brain.Model.V20180712;

namespace Aliyun.Acs.industry_brain.Transform.V20180712
{
    public class GetIndustryInfoResponseUnmarshaller
    {
        public static GetIndustryInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetIndustryInfoResponse getIndustryInfoResponse = new GetIndustryInfoResponse();

			getIndustryInfoResponse.HttpResponse = context.HttpResponse;
			getIndustryInfoResponse.RequestId = context.StringValue("GetIndustryInfo.RequestId");

			GetIndustryInfoResponse.GetIndustryInfo_IndustryInfo industryInfo = new GetIndustryInfoResponse.GetIndustryInfo_IndustryInfo();
			industryInfo.Id = context.StringValue("GetIndustryInfo.IndustryInfo.Id");
			industryInfo.Code = context.StringValue("GetIndustryInfo.IndustryInfo.Code");
			industryInfo.Name = context.StringValue("GetIndustryInfo.IndustryInfo.Name");
			industryInfo.Level = context.IntegerValue("GetIndustryInfo.IndustryInfo.Level");
			getIndustryInfoResponse.IndustryInfo = industryInfo;
        
			return getIndustryInfoResponse;
        }
    }
}
