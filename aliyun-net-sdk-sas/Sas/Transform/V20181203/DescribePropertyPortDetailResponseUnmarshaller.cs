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
        public static DescribePropertyPortDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyPortDetailResponse describePropertyPortDetailResponse = new DescribePropertyPortDetailResponse();

			describePropertyPortDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyPortDetailResponse.RequestId = _ctx.StringValue("DescribePropertyPortDetail.RequestId");

			DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PageInfo pageInfo = new DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyPortDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyPortDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyPortDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyPortDetail.PageInfo.CurrentPage");
			describePropertyPortDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort> describePropertyPortDetailResponse_propertys = new List<DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort>();
			for (int i = 0; i < _ctx.Length("DescribePropertyPortDetail.Propertys.Length"); i++) {
				DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort propertyPort = new DescribePropertyPortDetailResponse.DescribePropertyPortDetail_PropertyPort();
				propertyPort.BindIp = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].BindIp");
				propertyPort.Port = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Port");
				propertyPort.InstanceName = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InstanceName");
				propertyPort.Proto = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Proto");
				propertyPort.Ip = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Ip");
				propertyPort.Create = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Create");
				propertyPort.CreateTimestamp = _ctx.LongValue("DescribePropertyPortDetail.Propertys["+ i +"].CreateTimestamp");
				propertyPort.ProcName = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].ProcName");
				propertyPort.Uuid = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].Uuid");
				propertyPort.InstanceId = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InstanceId");
				propertyPort.IntranetIp = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].IntranetIp");
				propertyPort.InternetIp = _ctx.StringValue("DescribePropertyPortDetail.Propertys["+ i +"].InternetIp");

				describePropertyPortDetailResponse_propertys.Add(propertyPort);
			}
			describePropertyPortDetailResponse.Propertys = describePropertyPortDetailResponse_propertys;
        
			return describePropertyPortDetailResponse;
        }
    }
}
