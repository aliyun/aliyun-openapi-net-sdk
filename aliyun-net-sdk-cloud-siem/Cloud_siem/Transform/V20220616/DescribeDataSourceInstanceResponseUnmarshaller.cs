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
    public class DescribeDataSourceInstanceResponseUnmarshaller
    {
        public static DescribeDataSourceInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataSourceInstanceResponse describeDataSourceInstanceResponse = new DescribeDataSourceInstanceResponse();

			describeDataSourceInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDataSourceInstanceResponse.RequestId = _ctx.StringValue("DescribeDataSourceInstance.RequestId");

			DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data data = new DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data();
			data.DataSourceInstanceId = _ctx.StringValue("DescribeDataSourceInstance.Data.DataSourceInstanceId");
			data.AccountId = _ctx.StringValue("DescribeDataSourceInstance.Data.AccountId");
			data.CloudCode = _ctx.StringValue("DescribeDataSourceInstance.Data.CloudCode");

			List<DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data.DescribeDataSourceInstance_DataSourceInstanceParam> data_dataSourceInstanceParams = new List<DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data.DescribeDataSourceInstance_DataSourceInstanceParam>();
			for (int i = 0; i < _ctx.Length("DescribeDataSourceInstance.Data.DataSourceInstanceParams.Length"); i++) {
				DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data.DescribeDataSourceInstance_DataSourceInstanceParam dataSourceInstanceParam = new DescribeDataSourceInstanceResponse.DescribeDataSourceInstance_Data.DescribeDataSourceInstance_DataSourceInstanceParam();
				dataSourceInstanceParam.ParaCode = _ctx.StringValue("DescribeDataSourceInstance.Data.DataSourceInstanceParams["+ i +"].ParaCode");
				dataSourceInstanceParam.ParaValue = _ctx.StringValue("DescribeDataSourceInstance.Data.DataSourceInstanceParams["+ i +"].ParaValue");

				data_dataSourceInstanceParams.Add(dataSourceInstanceParam);
			}
			data.DataSourceInstanceParams = data_dataSourceInstanceParams;
			describeDataSourceInstanceResponse.Data = data;
        
			return describeDataSourceInstanceResponse;
        }
    }
}
