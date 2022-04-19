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
    public class DescribePropertyProcDetailResponseUnmarshaller
    {
        public static DescribePropertyProcDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyProcDetailResponse describePropertyProcDetailResponse = new DescribePropertyProcDetailResponse();

			describePropertyProcDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyProcDetailResponse.RequestId = _ctx.StringValue("DescribePropertyProcDetail.RequestId");

			DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PageInfo pageInfo = new DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyProcDetail.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyProcDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyProcDetail.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyProcDetail.PageInfo.Count");
			describePropertyProcDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PropertyProc> describePropertyProcDetailResponse_propertys = new List<DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PropertyProc>();
			for (int i = 0; i < _ctx.Length("DescribePropertyProcDetail.Propertys.Length"); i++) {
				DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PropertyProc propertyProc = new DescribePropertyProcDetailResponse.DescribePropertyProcDetail_PropertyProc();
				propertyProc.InternetIp = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].InternetIp");
				propertyProc.Pid = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Pid");
				propertyProc.User = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].User");
				propertyProc.InstanceId = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].InstanceId");
				propertyProc.Cmdline = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Cmdline");
				propertyProc.IntranetIp = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].IntranetIp");
				propertyProc.EuidName = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].EuidName");
				propertyProc.Uuid = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Uuid");
				propertyProc.StartTime = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].StartTime");
				propertyProc.Pname = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Pname");
				propertyProc.InstanceName = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].InstanceName");
				propertyProc.Path = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Path");
				propertyProc.Md5 = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Md5");
				propertyProc.Name = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].Name");
				propertyProc.CreateTimestamp = _ctx.LongValue("DescribePropertyProcDetail.Propertys["+ i +"].CreateTimestamp");
				propertyProc.StartTimeDt = _ctx.LongValue("DescribePropertyProcDetail.Propertys["+ i +"].StartTimeDt");
				propertyProc.IsPackage = _ctx.IntegerValue("DescribePropertyProcDetail.Propertys["+ i +"].IsPackage");
				propertyProc.State = _ctx.StringValue("DescribePropertyProcDetail.Propertys["+ i +"].State");

				describePropertyProcDetailResponse_propertys.Add(propertyProc);
			}
			describePropertyProcDetailResponse.Propertys = describePropertyProcDetailResponse_propertys;
        
			return describePropertyProcDetailResponse;
        }
    }
}
