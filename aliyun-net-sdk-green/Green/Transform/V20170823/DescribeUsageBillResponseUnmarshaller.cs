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
        public static DescribeUsageBillResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUsageBillResponse describeUsageBillResponse = new DescribeUsageBillResponse();

			describeUsageBillResponse.HttpResponse = context.HttpResponse;
			describeUsageBillResponse.RequestId = context.StringValue("DescribeUsageBill.RequestId");
			describeUsageBillResponse.TotalCount = context.IntegerValue("DescribeUsageBill.TotalCount");
			describeUsageBillResponse.PageSize = context.IntegerValue("DescribeUsageBill.PageSize");
			describeUsageBillResponse.CurrentPage = context.IntegerValue("DescribeUsageBill.CurrentPage");

			List<DescribeUsageBillResponse.DescribeUsageBill_Bill> describeUsageBillResponse_billList = new List<DescribeUsageBillResponse.DescribeUsageBill_Bill>();
			for (int i = 0; i < context.Length("DescribeUsageBill.BillList.Length"); i++) {
				DescribeUsageBillResponse.DescribeUsageBill_Bill bill = new DescribeUsageBillResponse.DescribeUsageBill_Bill();
				bill.Region = context.StringValue("DescribeUsageBill.BillList["+ i +"].Region");
				bill.Scene = context.StringValue("DescribeUsageBill.BillList["+ i +"].Scene");
				bill.TotalCount = context.LongValue("DescribeUsageBill.BillList["+ i +"].TotalCount");
				bill.ConfirmCount = context.LongValue("DescribeUsageBill.BillList["+ i +"].ConfirmCount");
				bill.ReviewCount = context.LongValue("DescribeUsageBill.BillList["+ i +"].ReviewCount");
				bill.FreeCount = context.LongValue("DescribeUsageBill.BillList["+ i +"].FreeCount");
				bill.SubUid = context.StringValue("DescribeUsageBill.BillList["+ i +"].SubUid");
				bill.BizType = context.StringValue("DescribeUsageBill.BillList["+ i +"].BizType");
				bill.Day = context.StringValue("DescribeUsageBill.BillList["+ i +"].Day");

				describeUsageBillResponse_billList.Add(bill);
			}
			describeUsageBillResponse.BillList = describeUsageBillResponse_billList;
        
			return describeUsageBillResponse;
        }
    }
}
