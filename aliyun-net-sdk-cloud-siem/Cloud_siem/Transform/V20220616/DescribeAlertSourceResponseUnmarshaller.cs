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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAlertSourceResponseUnmarshaller
    {
        public static DescribeAlertSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlertSourceResponse describeAlertSourceResponse = new DescribeAlertSourceResponse();

			describeAlertSourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAlertSourceResponse.Success = _ctx.BooleanValue("DescribeAlertSource.Success");
			describeAlertSourceResponse.Code = _ctx.IntegerValue("DescribeAlertSource.Code");
			describeAlertSourceResponse.Message = _ctx.StringValue("DescribeAlertSource.Message");
			describeAlertSourceResponse.RequestId = _ctx.StringValue("DescribeAlertSource.RequestId");

			List<DescribeAlertSourceResponse.DescribeAlertSource_DataItem> describeAlertSourceResponse_data = new List<DescribeAlertSourceResponse.DescribeAlertSource_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlertSource.Data.Length"); i++) {
				DescribeAlertSourceResponse.DescribeAlertSource_DataItem dataItem = new DescribeAlertSourceResponse.DescribeAlertSource_DataItem();
				dataItem.SourceName = _ctx.StringValue("DescribeAlertSource.Data["+ i +"].SourceName");
				dataItem.Source = _ctx.StringValue("DescribeAlertSource.Data["+ i +"].Source");

				describeAlertSourceResponse_data.Add(dataItem);
			}
			describeAlertSourceResponse.Data = describeAlertSourceResponse_data;
        
			return describeAlertSourceResponse;
        }
    }
}
