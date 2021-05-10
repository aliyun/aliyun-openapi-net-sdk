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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserSecDropByMinuteResponseUnmarshaller
    {
        public static DescribeDcdnUserSecDropByMinuteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnUserSecDropByMinuteResponse describeDcdnUserSecDropByMinuteResponse = new DescribeDcdnUserSecDropByMinuteResponse();

			describeDcdnUserSecDropByMinuteResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnUserSecDropByMinuteResponse.RequestId = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.RequestId");
			describeDcdnUserSecDropByMinuteResponse.Description = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Description");
			describeDcdnUserSecDropByMinuteResponse.TotalCount = _ctx.IntegerValue("DescribeDcdnUserSecDropByMinute.TotalCount");
			describeDcdnUserSecDropByMinuteResponse.Len = _ctx.IntegerValue("DescribeDcdnUserSecDropByMinute.Len");
			describeDcdnUserSecDropByMinuteResponse.PageNumber = _ctx.IntegerValue("DescribeDcdnUserSecDropByMinute.PageNumber");
			describeDcdnUserSecDropByMinuteResponse.PageSize = _ctx.IntegerValue("DescribeDcdnUserSecDropByMinute.PageSize");

			List<DescribeDcdnUserSecDropByMinuteResponse.DescribeDcdnUserSecDropByMinute_RowsItem> describeDcdnUserSecDropByMinuteResponse_rows = new List<DescribeDcdnUserSecDropByMinuteResponse.DescribeDcdnUserSecDropByMinute_RowsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnUserSecDropByMinute.Rows.Length"); i++) {
				DescribeDcdnUserSecDropByMinuteResponse.DescribeDcdnUserSecDropByMinute_RowsItem rowsItem = new DescribeDcdnUserSecDropByMinuteResponse.DescribeDcdnUserSecDropByMinute_RowsItem();
				rowsItem.RuleName = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].RuleName");
				rowsItem._Object = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].Object");
				rowsItem.Domain = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].Domain");
				rowsItem.SecFunc = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].SecFunc");
				rowsItem.TmStr = _ctx.StringValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].TmStr");
				rowsItem.Drops = _ctx.IntegerValue("DescribeDcdnUserSecDropByMinute.Rows["+ i +"].Drops");

				describeDcdnUserSecDropByMinuteResponse_rows.Add(rowsItem);
			}
			describeDcdnUserSecDropByMinuteResponse.Rows = describeDcdnUserSecDropByMinuteResponse_rows;
        
			return describeDcdnUserSecDropByMinuteResponse;
        }
    }
}
