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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeLoghubDetailResponseUnmarshaller
    {
        public static DescribeLoghubDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoghubDetailResponse describeLoghubDetailResponse = new DescribeLoghubDetailResponse();

			describeLoghubDetailResponse.HttpResponse = context.HttpResponse;
			describeLoghubDetailResponse.RequestId = context.StringValue("DescribeLoghubDetail.RequestId");

			DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo loghubInfo = new DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo();
			loghubInfo.ProjectName = context.StringValue("DescribeLoghubDetail.LoghubInfo.ProjectName");
			loghubInfo.LogStoreName = context.StringValue("DescribeLoghubDetail.LoghubInfo.LogStoreName");
			loghubInfo.DeliverName = context.StringValue("DescribeLoghubDetail.LoghubInfo.DeliverName");
			loghubInfo.DeliverTime = context.StringValue("DescribeLoghubDetail.LoghubInfo.DeliverTime");
			loghubInfo.DomainUrl = context.StringValue("DescribeLoghubDetail.LoghubInfo.DomainUrl");
			loghubInfo.Description = context.StringValue("DescribeLoghubDetail.LoghubInfo.Description");
			loghubInfo.SchemaName = context.StringValue("DescribeLoghubDetail.LoghubInfo.SchemaName");
			loghubInfo.TableName = context.StringValue("DescribeLoghubDetail.LoghubInfo.TableName");
			loghubInfo.RegionId = context.StringValue("DescribeLoghubDetail.LoghubInfo.RegionId");
			loghubInfo.ZoneId = context.StringValue("DescribeLoghubDetail.LoghubInfo.ZoneId");
			loghubInfo.UserName = context.StringValue("DescribeLoghubDetail.LoghubInfo.UserName");
			loghubInfo.Password = context.StringValue("DescribeLoghubDetail.LoghubInfo.Password");
			loghubInfo.FilterDirtyData = context.BooleanValue("DescribeLoghubDetail.LoghubInfo.FilterDirtyData");
			loghubInfo.AccessKey = context.StringValue("DescribeLoghubDetail.LoghubInfo.AccessKey");
			loghubInfo.AccessSecret = context.StringValue("DescribeLoghubDetail.LoghubInfo.AccessSecret");
			loghubInfo.DBType = context.StringValue("DescribeLoghubDetail.LoghubInfo.DBType");
			loghubInfo.DBClusterId = context.StringValue("DescribeLoghubDetail.LoghubInfo.DBClusterId");

			List<DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo.DescribeLoghubDetail_LogHubStore> loghubInfo_logHubStores = new List<DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo.DescribeLoghubDetail_LogHubStore>();
			for (int i = 0; i < context.Length("DescribeLoghubDetail.LoghubInfo.LogHubStores.Length"); i++) {
				DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo.DescribeLoghubDetail_LogHubStore logHubStore = new DescribeLoghubDetailResponse.DescribeLoghubDetail_LoghubInfo.DescribeLoghubDetail_LogHubStore();
				logHubStore.LogKey = context.StringValue("DescribeLoghubDetail.LoghubInfo.LogHubStores["+ i +"].LogKey");
				logHubStore.FieldKey = context.StringValue("DescribeLoghubDetail.LoghubInfo.LogHubStores["+ i +"].FieldKey");
				logHubStore.Type = context.StringValue("DescribeLoghubDetail.LoghubInfo.LogHubStores["+ i +"].Type");

				loghubInfo_logHubStores.Add(logHubStore);
			}
			loghubInfo.LogHubStores = loghubInfo_logHubStores;
			describeLoghubDetailResponse.LoghubInfo = loghubInfo;
        
			return describeLoghubDetailResponse;
        }
    }
}
