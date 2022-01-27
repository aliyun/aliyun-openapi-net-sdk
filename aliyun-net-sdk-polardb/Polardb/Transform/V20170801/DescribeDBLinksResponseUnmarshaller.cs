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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBLinksResponseUnmarshaller
    {
        public static DescribeDBLinksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBLinksResponse describeDBLinksResponse = new DescribeDBLinksResponse();

			describeDBLinksResponse.HttpResponse = _ctx.HttpResponse;
			describeDBLinksResponse.RequestId = _ctx.StringValue("DescribeDBLinks.RequestId");
			describeDBLinksResponse.DBInstanceName = _ctx.StringValue("DescribeDBLinks.DBInstanceName");

			List<DescribeDBLinksResponse.DescribeDBLinks_DBLinkInfosItem> describeDBLinksResponse_dBLinkInfos = new List<DescribeDBLinksResponse.DescribeDBLinks_DBLinkInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBLinks.DBLinkInfos.Length"); i++) {
				DescribeDBLinksResponse.DescribeDBLinks_DBLinkInfosItem dBLinkInfosItem = new DescribeDBLinksResponse.DescribeDBLinks_DBLinkInfosItem();
				dBLinkInfosItem.TargetDBInstanceName = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].TargetDBInstanceName");
				dBLinkInfosItem.DBInstanceName = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].DBInstanceName");
				dBLinkInfosItem.TargetDBName = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].TargetDBName");
				dBLinkInfosItem.TargetAccount = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].TargetAccount");
				dBLinkInfosItem.DBLinkName = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].DBLinkName");
				dBLinkInfosItem.SourceDBName = _ctx.StringValue("DescribeDBLinks.DBLinkInfos["+ i +"].SourceDBName");

				describeDBLinksResponse_dBLinkInfos.Add(dBLinkInfosItem);
			}
			describeDBLinksResponse.DBLinkInfos = describeDBLinksResponse_dBLinkInfos;
        
			return describeDBLinksResponse;
        }
    }
}
