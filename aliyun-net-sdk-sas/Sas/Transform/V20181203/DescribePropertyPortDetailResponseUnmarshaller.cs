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
    public class DescribePropertyPortDetailResponseUnmarshaller
    {
        public static DescribePropertyPortDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePropertyPortDetailResponse describePropertyPortDetailResponse = new DescribePropertyPortDetailResponse();

			describePropertyPortDetailResponse.HttpResponse = context.HttpResponse;
			describePropertyPortDetailResponse.RequestId = context.StringValue("DescribePropertyPortDetail.RequestId");

			DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PageInfo pageInfo = new DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribePropertyPortDetail.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribePropertyPortDetail.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribePropertyPortDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribePropertyPortDetail.PageInfo.CurrentPage");
			describePropertyPortDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort> describePropertyPortDetailResponse_propertys = new List<DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort>();
			for (int i = 0; i < context.Length("DescribePropertyPortDetail.Propertys.Length"); i++) {
				DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort propertyPort = new DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort();
				propertyPort.BindIp = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].BindIp");
				propertyPort.Port = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Port");
				propertyPort.InstanceName = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InstanceName");
				propertyPort.Proto = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Proto");
				propertyPort.Ip = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Ip");
				propertyPort.Create = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Create");
				propertyPort.CreateTimestamp = context.LongValue("DescribePropertyPortDetail.Propertys["+ i +"].CreateTimestamp");
				propertyPort.ProcName = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].ProcName");
				propertyPort.Uuid = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Uuid");
				propertyPort.InstanceId = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InstanceId");
				propertyPort.IntranetIp = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].IntranetIp");
				propertyPort.InternetIp = context.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InternetIp");

				describePropertyPortDetailResponse_propertys.Add(propertyPort);
			}
			describePropertyPortDetailResponse.Propertys = describePropertyPortDetailResponse_propertys;
        
			return describePropertyPortDetailResponse;
        }
    }
}
