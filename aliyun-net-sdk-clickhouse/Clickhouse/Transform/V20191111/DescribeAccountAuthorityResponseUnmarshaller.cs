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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeAccountAuthorityResponseUnmarshaller
    {
        public static DescribeAccountAuthorityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountAuthorityResponse describeAccountAuthorityResponse = new DescribeAccountAuthorityResponse();

			describeAccountAuthorityResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountAuthorityResponse.DdlAuthority = _ctx.BooleanValue("DescribeAccountAuthority.DdlAuthority");
			describeAccountAuthorityResponse.DmlAuthority = _ctx.StringValue("DescribeAccountAuthority.DmlAuthority");
			describeAccountAuthorityResponse.RequestId = _ctx.StringValue("DescribeAccountAuthority.RequestId");
			describeAccountAuthorityResponse.AccountName = _ctx.StringValue("DescribeAccountAuthority.AccountName");

			List<string> describeAccountAuthorityResponse_totalDatabases = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAccountAuthority.TotalDatabases.Length"); i++) {
				describeAccountAuthorityResponse_totalDatabases.Add(_ctx.StringValue("DescribeAccountAuthority.TotalDatabases["+ i +"]"));
			}
			describeAccountAuthorityResponse.TotalDatabases = describeAccountAuthorityResponse_totalDatabases;

			List<string> describeAccountAuthorityResponse_totalDictionaries = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAccountAuthority.TotalDictionaries.Length"); i++) {
				describeAccountAuthorityResponse_totalDictionaries.Add(_ctx.StringValue("DescribeAccountAuthority.TotalDictionaries["+ i +"]"));
			}
			describeAccountAuthorityResponse.TotalDictionaries = describeAccountAuthorityResponse_totalDictionaries;

			List<string> describeAccountAuthorityResponse_allowDictionaries = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAccountAuthority.AllowDictionaries.Length"); i++) {
				describeAccountAuthorityResponse_allowDictionaries.Add(_ctx.StringValue("DescribeAccountAuthority.AllowDictionaries["+ i +"]"));
			}
			describeAccountAuthorityResponse.AllowDictionaries = describeAccountAuthorityResponse_allowDictionaries;

			List<string> describeAccountAuthorityResponse_allowDatabases = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAccountAuthority.AllowDatabases.Length"); i++) {
				describeAccountAuthorityResponse_allowDatabases.Add(_ctx.StringValue("DescribeAccountAuthority.AllowDatabases["+ i +"]"));
			}
			describeAccountAuthorityResponse.AllowDatabases = describeAccountAuthorityResponse_allowDatabases;
        
			return describeAccountAuthorityResponse;
        }
    }
}
