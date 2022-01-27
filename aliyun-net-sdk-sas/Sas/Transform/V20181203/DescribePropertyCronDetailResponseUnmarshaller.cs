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
    public class DescribePropertyCronDetailResponseUnmarshaller
    {
        public static DescribePropertyCronDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyCronDetailResponse describePropertyCronDetailResponse = new DescribePropertyCronDetailResponse();

			describePropertyCronDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyCronDetailResponse.RequestId = _ctx.StringValue("DescribePropertyCronDetail.RequestId");

			DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PageInfo pageInfo = new DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyCronDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyCronDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyCronDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyCronDetail.PageInfo.CurrentPage");
			describePropertyCronDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PropertyCron> describePropertyCronDetailResponse_propertys = new List<DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PropertyCron>();
			for (int i = 0; i < _ctx.Length("DescribePropertyCronDetail.Propertys.Length"); i++) {
				DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PropertyCron propertyCron = new DescribePropertyCronDetailResponse.DescribePropertyCronDetail_PropertyCron();
				propertyCron.InstanceName = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].InstanceName");
				propertyCron.Ip = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Ip");
				propertyCron.Create = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Create");
				propertyCron.CreateTimestamp = _ctx.LongValue("DescribePropertyCronDetail.Propertys["+ i +"].CreateTimestamp");
				propertyCron.Uuid = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Uuid");
				propertyCron.InstanceId = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].InstanceId");
				propertyCron.IntranetIp = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].IntranetIp");
				propertyCron.InternetIp = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].InternetIp");
				propertyCron.Period = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Period");
				propertyCron.Source = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Source");
				propertyCron.Cmd = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Cmd");
				propertyCron.User = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].User");
				propertyCron.Md5 = _ctx.StringValue("DescribePropertyCronDetail.Propertys["+ i +"].Md5");

				describePropertyCronDetailResponse_propertys.Add(propertyCron);
			}
			describePropertyCronDetailResponse.Propertys = describePropertyCronDetailResponse_propertys;
        
			return describePropertyCronDetailResponse;
        }
    }
}
