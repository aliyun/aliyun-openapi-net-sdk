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
    public class DescribeDataSourceParametersResponseUnmarshaller
    {
        public static DescribeDataSourceParametersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataSourceParametersResponse describeDataSourceParametersResponse = new DescribeDataSourceParametersResponse();

			describeDataSourceParametersResponse.HttpResponse = _ctx.HttpResponse;
			describeDataSourceParametersResponse.RequestId = _ctx.StringValue("DescribeDataSourceParameters.RequestId");

			List<DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem> describeDataSourceParametersResponse_data = new List<DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeDataSourceParameters.Data.Length"); i++) {
				DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem dataItem = new DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem();
				dataItem.DataSourceType = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].DataSourceType");
				dataItem.ParaLevel = _ctx.IntegerValue("DescribeDataSourceParameters.Data["+ i +"].ParaLevel");
				dataItem.ParaCode = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].ParaCode");
				dataItem.ParaName = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].ParaName");
				dataItem.ParaType = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].ParaType");
				dataItem.Required = _ctx.IntegerValue("DescribeDataSourceParameters.Data["+ i +"].Required");
				dataItem.FormatCheck = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].FormatCheck");
				dataItem.Title = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].Title");
				dataItem.Hit = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].Hit");
				dataItem.DefaultValue = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].DefaultValue");
				dataItem.Disabled = _ctx.BooleanValue("DescribeDataSourceParameters.Data["+ i +"].Disabled");
				dataItem.CanEditted = _ctx.IntegerValue("DescribeDataSourceParameters.Data["+ i +"].CanEditted");
				dataItem.CloudCode = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].CloudCode");

				List<DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem.DescribeDataSourceParameters_ParamValueItem> dataItem_paramValue = new List<DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem.DescribeDataSourceParameters_ParamValueItem>();
				for (int j = 0; j < _ctx.Length("DescribeDataSourceParameters.Data["+ i +"].ParamValue.Length"); j++) {
					DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem.DescribeDataSourceParameters_ParamValueItem paramValueItem = new DescribeDataSourceParametersResponse.DescribeDataSourceParameters_DataItem.DescribeDataSourceParameters_ParamValueItem();
					paramValueItem.Label = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].ParamValue["+ j +"].Label");
					paramValueItem._Value = _ctx.StringValue("DescribeDataSourceParameters.Data["+ i +"].ParamValue["+ j +"].Value");

					dataItem_paramValue.Add(paramValueItem);
				}
				dataItem.ParamValue = dataItem_paramValue;

				describeDataSourceParametersResponse_data.Add(dataItem);
			}
			describeDataSourceParametersResponse.Data = describeDataSourceParametersResponse_data;
        
			return describeDataSourceParametersResponse;
        }
    }
}
