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
    public class CheckScaleOutBalancedResponseUnmarshaller
    {
        public static CheckScaleOutBalancedResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckScaleOutBalancedResponse checkScaleOutBalancedResponse = new CheckScaleOutBalancedResponse();

			checkScaleOutBalancedResponse.HttpResponse = _ctx.HttpResponse;
			checkScaleOutBalancedResponse.TotalCount = _ctx.IntegerValue("CheckScaleOutBalanced.TotalCount");
			checkScaleOutBalancedResponse.RequestId = _ctx.StringValue("CheckScaleOutBalanced.RequestId");
			checkScaleOutBalancedResponse.PageSize = _ctx.IntegerValue("CheckScaleOutBalanced.PageSize");
			checkScaleOutBalancedResponse.PageNumber = _ctx.IntegerValue("CheckScaleOutBalanced.PageNumber");
			checkScaleOutBalancedResponse.CheckCode = _ctx.StringValue("CheckScaleOutBalanced.CheckCode");
			checkScaleOutBalancedResponse.TimeDuration = _ctx.StringValue("CheckScaleOutBalanced.TimeDuration");

			List<CheckScaleOutBalancedResponse.CheckScaleOutBalanced_TableDetail> checkScaleOutBalancedResponse_tableDetails = new List<CheckScaleOutBalancedResponse.CheckScaleOutBalanced_TableDetail>();
			for (int i = 0; i < _ctx.Length("CheckScaleOutBalanced.TableDetails.Length"); i++) {
				CheckScaleOutBalancedResponse.CheckScaleOutBalanced_TableDetail tableDetail = new CheckScaleOutBalancedResponse.CheckScaleOutBalanced_TableDetail();
				tableDetail.TableName = _ctx.StringValue("CheckScaleOutBalanced.TableDetails["+ i +"].TableName");
				tableDetail.Cluster = _ctx.StringValue("CheckScaleOutBalanced.TableDetails["+ i +"].Cluster");
				tableDetail.Database = _ctx.StringValue("CheckScaleOutBalanced.TableDetails["+ i +"].Database");
				tableDetail.Detail = _ctx.IntegerValue("CheckScaleOutBalanced.TableDetails["+ i +"].Detail");

				checkScaleOutBalancedResponse_tableDetails.Add(tableDetail);
			}
			checkScaleOutBalancedResponse.TableDetails = checkScaleOutBalancedResponse_tableDetails;
        
			return checkScaleOutBalancedResponse;
        }
    }
}
