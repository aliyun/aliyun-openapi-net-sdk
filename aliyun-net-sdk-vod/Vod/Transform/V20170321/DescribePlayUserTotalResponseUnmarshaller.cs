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
    public class DescribePlayUserTotalResponseUnmarshaller
    {
        public static DescribePlayUserTotalResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePlayUserTotalResponse describePlayUserTotalResponse = new DescribePlayUserTotalResponse();

			describePlayUserTotalResponse.HttpResponse = context.HttpResponse;
			describePlayUserTotalResponse.RequestId = context.StringValue("DescribePlayUserTotal.RequestId");

			List<DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal> describePlayUserTotalResponse_userPlayStatisTotals = new List<DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal>();
			for (int i = 0; i < context.Length("DescribePlayUserTotal.UserPlayStatisTotals.Length"); i++) {
				DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal userPlayStatisTotal = new DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal();
				userPlayStatisTotal.Date = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].Date");
				userPlayStatisTotal.PlayDuration = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].PlayDuration");
				userPlayStatisTotal.PlayRange = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].PlayRange");

				DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal.DescribePlayUserTotal_VV vV = new DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal.DescribePlayUserTotal_VV();
				vV.Android = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].VV.Android");
				vV.IOS = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].VV.iOS");
				vV.Flash = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].VV.Flash");
				vV.HTML5 = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].VV.HTML5");
				userPlayStatisTotal.VV = vV;

				DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal.DescribePlayUserTotal_UV uV = new DescribePlayUserTotalResponse.DescribePlayUserTotal_UserPlayStatisTotal.DescribePlayUserTotal_UV();
				uV.Android = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].UV.Android");
				uV.IOS = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].UV.iOS");
				uV.Flash = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].UV.Flash");
				uV.HTML5 = context.StringValue("DescribePlayUserTotal.UserPlayStatisTotals["+ i +"].UV.HTML5");
				userPlayStatisTotal.UV = uV;

				describePlayUserTotalResponse_userPlayStatisTotals.Add(userPlayStatisTotal);
			}
			describePlayUserTotalResponse.UserPlayStatisTotals = describePlayUserTotalResponse_userPlayStatisTotals;
        
			return describePlayUserTotalResponse;
        }
    }
}
