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
    public class GetOSSImageAccessResponseUnmarshaller
    {
        public static GetOSSImageAccessResponse Unmarshall(UnmarshallerContext context)
        {
			GetOSSImageAccessResponse getOSSImageAccessResponse = new GetOSSImageAccessResponse();

			getOSSImageAccessResponse.HttpResponse = context.HttpResponse;
			getOSSImageAccessResponse.RequestId = context.StringValue("GetOSSImageAccess.RequestId");

			GetOSSImageAccessResponse.GetOSSImageAccess_StsInfo stsInfo = new GetOSSImageAccessResponse.GetOSSImageAccess_StsInfo();
			stsInfo.AccessKeyId = context.StringValue("GetOSSImageAccess.StsInfo.AccessKeyId");
			stsInfo.AccessKeySecret = context.StringValue("GetOSSImageAccess.StsInfo.AccessKeySecret");
			stsInfo.SecurityToken = context.StringValue("GetOSSImageAccess.StsInfo.SecurityToken");
			stsInfo.Expiration = context.StringValue("GetOSSImageAccess.StsInfo.Expiration");
			stsInfo.BucketName = context.StringValue("GetOSSImageAccess.StsInfo.BucketName");
			stsInfo.Endpoint = context.StringValue("GetOSSImageAccess.StsInfo.Endpoint");

			List<string> stsInfo_prefixList = new List<string>();
			for (int i = 0; i < context.Length("GetOSSImageAccess.StsInfo.PrefixList.Length"); i++) {
				stsInfo_prefixList.Add(context.StringValue("GetOSSImageAccess.StsInfo.PrefixList["+ i +"]"));
			}
			stsInfo.PrefixList = stsInfo_prefixList;
			getOSSImageAccessResponse.StsInfo = stsInfo;
        
			return getOSSImageAccessResponse;
        }
    }
}
