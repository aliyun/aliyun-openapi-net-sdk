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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribePropertySoftwareDetailResponseUnmarshaller
    {
        public static DescribePropertySoftwareDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePropertySoftwareDetailResponse describePropertySoftwareDetailResponse = new DescribePropertySoftwareDetailResponse();

			describePropertySoftwareDetailResponse.HttpResponse = context.HttpResponse;
			describePropertySoftwareDetailResponse.RequestId = context.StringValue("DescribePropertySoftwareDetail.RequestId");

			DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PageInfo pageInfo = new DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribePropertySoftwareDetail.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribePropertySoftwareDetail.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribePropertySoftwareDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribePropertySoftwareDetail.PageInfo.CurrentPage");
			describePropertySoftwareDetailResponse.PageInfo = pageInfo;

			List<DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware> describePropertySoftwareDetailResponse_propertys = new List<DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware>();
			for (int i = 0; i < context.Length("DescribePropertySoftwareDetail.Propertys.Length"); i++) {
				DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware propertySoftware = new DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware();
				propertySoftware.Name = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Name");
				propertySoftware.Path = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Path");
				propertySoftware.InstanceName = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstanceName");
				propertySoftware.Ip = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Ip");
				propertySoftware.Create = context.LongValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Create");
				propertySoftware.CreateTimestamp = context.LongValue("DescribePropertySoftwareDetail.Propertys["+ i +"].CreateTimestamp");
				propertySoftware.InstallTime = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstallTime");
				propertySoftware.Version = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Version");
				propertySoftware.Uuid = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Uuid");
				propertySoftware.InstanceId = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstanceId");
				propertySoftware.IntranetIp = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].IntranetIp");
				propertySoftware.InternetIp = context.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InternetIp");

				describePropertySoftwareDetailResponse_propertys.Add(propertySoftware);
			}
			describePropertySoftwareDetailResponse.Propertys = describePropertySoftwareDetailResponse_propertys;
        
			return describePropertySoftwareDetailResponse;
        }
    }
}
