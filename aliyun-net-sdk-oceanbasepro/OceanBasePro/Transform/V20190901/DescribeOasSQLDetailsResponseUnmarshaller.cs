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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeOasSQLDetailsResponseUnmarshaller
    {
        public static DescribeOasSQLDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOasSQLDetailsResponse describeOasSQLDetailsResponse = new DescribeOasSQLDetailsResponse();

			describeOasSQLDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeOasSQLDetailsResponse.RequestId = _ctx.StringValue("DescribeOasSQLDetails.RequestId");

			DescribeOasSQLDetailsResponse.DescribeOasSQLDetails_Data data = new DescribeOasSQLDetailsResponse.DescribeOasSQLDetails_Data();
			data.Fulltext = _ctx.StringValue("DescribeOasSQLDetails.Data.Fulltext");
			data.UserName = _ctx.StringValue("DescribeOasSQLDetails.Data.UserName");
			data.Statement = _ctx.StringValue("DescribeOasSQLDetails.Data.Statement");
			data.DbName = _ctx.StringValue("DescribeOasSQLDetails.Data.DbName");

			List<string> data_tables = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOasSQLDetails.Data.Tables.Length"); i++) {
				data_tables.Add(_ctx.StringValue("DescribeOasSQLDetails.Data.Tables["+ i +"]"));
			}
			data.Tables = data_tables;
			describeOasSQLDetailsResponse.Data = data;
        
			return describeOasSQLDetailsResponse;
        }
    }
}
