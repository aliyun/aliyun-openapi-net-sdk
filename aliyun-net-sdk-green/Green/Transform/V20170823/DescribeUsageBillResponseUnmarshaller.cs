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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeUsageBillResponseUnmarshaller
    {
        public static DescribeUsageBillResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUsageBillResponse describeUsageBillResponse = new DescribeUsageBillResponse();

			describeUsageBillResponse.HttpResponse = _ctx.HttpResponse;
			describeUsageBillResponse.RequestId = _ctx.StringValue("DescribeUsageBill.RequestId");
			describeUsageBillResponse.TotalCount = _ctx.IntegerValue("DescribeUsageBill.TotalCount");
			describeUsageBillResponse.PageSize = _ctx.IntegerValue("DescribeUsageBill.PageSize");
			describeUsageBillResponse.CurrentPage = _ctx.IntegerValue("DescribeUsageBill.CurrentPage");

			List<DescribeUsageBillResponse.DescribeUsageBill_Bill> describeUsageBillResponse_billList = new List<DescribeUsageBillResponse.DescribeUsageBill_Bill>();
			for (int i = 0; i < _ctx.Length("DescribeUsageBill.BillList.Length"); i++) {
				DescribeUsageBillResponse.DescribeUsageBill_Bill bill = new DescribeUsageBillResponse.DescribeUsageBill_Bill();
				bill.Region = _ctx.StringValue("DescribeUsageBill.BillList["+ i +"].Region");
				bill.Scene = _ctx.StringValue("DescribeUsageBill.BillList["+ i +"].Scene");
				bill.TotalCount = _ctx.LongValue("DescribeUsageBill.BillList["+ i +"].TotalCount");
				bill.ConfirmCount = _ctx.LongValue("DescribeUsageBill.BillList["+ i +"].ConfirmCount");
				bill.ReviewCount = _ctx.LongValue("DescribeUsageBill.BillList["+ i +"].ReviewCount");
				bill.FreeCount = _ctx.LongValue("DescribeUsageBill.BillList["+ i +"].FreeCount");
				bill.SubUid = _ctx.StringValue("DescribeUsageBill.BillList["+ i +"].SubUid");
				bill.BizType = _ctx.StringValue("DescribeUsageBill.BillList["+ i +"].BizType");
				bill.Day = _ctx.StringValue("DescribeUsageBill.BillList["+ i +"].Day");

				describeUsageBillResponse_billList.Add(bill);
			}
			describeUsageBillResponse.BillList = describeUsageBillResponse_billList;
        
			return describeUsageBillResponse;
        }
    }
}
