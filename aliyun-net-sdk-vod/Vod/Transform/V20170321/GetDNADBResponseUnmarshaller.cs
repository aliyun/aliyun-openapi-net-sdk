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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetDNADBResponseUnmarshaller
    {
        public static GetDNADBResponse Unmarshall(UnmarshallerContext context)
        {
			GetDNADBResponse getDNADBResponse = new GetDNADBResponse();

			getDNADBResponse.HttpResponse = context.HttpResponse;
			getDNADBResponse.RequestId = context.StringValue("GetDNADB.RequestId");

			GetDNADBResponse.GetDNADB_DNADB dNADB = new GetDNADBResponse.GetDNADB_DNADB();
			dNADB.DBId = context.StringValue("GetDNADB.DNADB.DBId");
			dNADB.Status = context.StringValue("GetDNADB.DNADB.Status");
			dNADB.DBDescription = context.StringValue("GetDNADB.DNADB.DBDescription");
			dNADB.DBType = context.StringValue("GetDNADB.DNADB.DBType");
			dNADB.DBName = context.StringValue("GetDNADB.DNADB.DBName");
			dNADB.DBRegion = context.StringValue("GetDNADB.DNADB.DBRegion");
			getDNADBResponse.DNADB = dNADB;
        
			return getDNADBResponse;
        }
    }
}
