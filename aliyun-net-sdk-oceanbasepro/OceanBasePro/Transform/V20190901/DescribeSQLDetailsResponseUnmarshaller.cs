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
    public class DescribeSQLDetailsResponseUnmarshaller
    {
        public static DescribeSQLDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLDetailsResponse describeSQLDetailsResponse = new DescribeSQLDetailsResponse();

			describeSQLDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLDetailsResponse.RequestId = _ctx.StringValue("DescribeSQLDetails.RequestId");

			List<DescribeSQLDetailsResponse.DescribeSQLDetails_Data> describeSQLDetailsResponse_sQLDetails = new List<DescribeSQLDetailsResponse.DescribeSQLDetails_Data>();
			for (int i = 0; i < _ctx.Length("DescribeSQLDetails.SQLDetails.Length"); i++) {
				DescribeSQLDetailsResponse.DescribeSQLDetails_Data data = new DescribeSQLDetailsResponse.DescribeSQLDetails_Data();
				data.SQLText = _ctx.StringValue("DescribeSQLDetails.SQLDetails["+ i +"].SQLText");
				data.DbName = _ctx.StringValue("DescribeSQLDetails.SQLDetails["+ i +"].DbName");
				data.UserName = _ctx.StringValue("DescribeSQLDetails.SQLDetails["+ i +"].UserName");

				describeSQLDetailsResponse_sQLDetails.Add(data);
			}
			describeSQLDetailsResponse.SQLDetails = describeSQLDetailsResponse_sQLDetails;
        
			return describeSQLDetailsResponse;
        }
    }
}
