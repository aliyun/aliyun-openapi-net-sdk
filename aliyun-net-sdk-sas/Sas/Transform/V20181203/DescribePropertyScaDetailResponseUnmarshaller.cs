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
    public class DescribePropertyScaDetailResponseUnmarshaller
    {
        public static DescribePropertyScaDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyScaDetailResponse describePropertyScaDetailResponse = new DescribePropertyScaDetailResponse();

			describePropertyScaDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyScaDetailResponse.RequestId = _ctx.StringValue("DescribePropertyScaDetail.RequestId");

			DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PageInfo pageInfo = new DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyScaDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyScaDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyScaDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyScaDetail.PageInfo.CurrentPage");
			describePropertyScaDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PropertySca> describePropertyScaDetailResponse_propertys = new List<DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PropertySca>();
			for (int i = 0; i < _ctx.Length("DescribePropertyScaDetail.Propertys.Length"); i++) {
				DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PropertySca propertySca = new DescribePropertyScaDetailResponse.DescribePropertyScaDetail_PropertySca();
				propertySca.InstanceName = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].InstanceName");
				propertySca.Ip = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Ip");
				propertySca.Create = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Create");
				propertySca.CreateTimestamp = _ctx.LongValue("DescribePropertyScaDetail.Propertys["+ i +"].CreateTimestamp");
				propertySca.Uuid = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Uuid");
				propertySca.InstanceId = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].InstanceId");
				propertySca.IntranetIp = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].IntranetIp");
				propertySca.InternetIp = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].InternetIp");
				propertySca.Name = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Name");
				propertySca.Type = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Type");
				propertySca.Version = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Version");
				propertySca.Pid = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Pid");
				propertySca.BizType = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].BizType");
				propertySca.BizTypeDispaly = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].BizTypeDispaly");
				propertySca.Port = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Port");
				propertySca.ContainerName = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ContainerName");
				propertySca.Path = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Path");
				propertySca.Ppid = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Ppid");
				propertySca.ProcessUser = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ProcessUser");
				propertySca.ListenIp = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ListenIp");
				propertySca.ListenStatus = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ListenStatus");
				propertySca.ListenProtocol = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ListenProtocol");
				propertySca.ProcessStarted = _ctx.LongValue("DescribePropertyScaDetail.Propertys["+ i +"].ProcessStarted");
				propertySca.Cmdline = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Cmdline");
				propertySca.ConfigPath = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ConfigPath");
				propertySca.WebPath = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].WebPath");
				propertySca.Proof = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].Proof");
				propertySca.ImageName = _ctx.StringValue("DescribePropertyScaDetail.Propertys["+ i +"].ImageName");

				describePropertyScaDetailResponse_propertys.Add(propertySca);
			}
			describePropertyScaDetailResponse.Propertys = describePropertyScaDetailResponse_propertys;
        
			return describePropertyScaDetailResponse;
        }
    }
}
