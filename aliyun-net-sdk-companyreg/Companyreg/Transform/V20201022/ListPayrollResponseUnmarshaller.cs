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
using Aliyun.Acs.companyreg.Model.V20201022;

namespace Aliyun.Acs.companyreg.Transform.V20201022
{
    public class ListPayrollResponseUnmarshaller
    {
        public static ListPayrollResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPayrollResponse listPayrollResponse = new ListPayrollResponse();

			listPayrollResponse.HttpResponse = _ctx.HttpResponse;
			listPayrollResponse.RequestId = _ctx.StringValue("ListPayroll.RequestId");

			List<ListPayrollResponse.ListPayroll_PayrollListItem> listPayrollResponse_payrollList = new List<ListPayrollResponse.ListPayroll_PayrollListItem>();
			for (int i = 0; i < _ctx.Length("ListPayroll.PayrollList.Length"); i++) {
				ListPayrollResponse.ListPayroll_PayrollListItem payrollListItem = new ListPayrollResponse.ListPayroll_PayrollListItem();
				payrollListItem.Name = _ctx.StringValue("ListPayroll.PayrollList["+ i +"].Name");
				payrollListItem.Income = _ctx.StringValue("ListPayroll.PayrollList["+ i +"].Income");
				payrollListItem.PersonHousingAccumulationFund = _ctx.StringValue("ListPayroll.PayrollList["+ i +"].PersonHousingAccumulationFund");
				payrollListItem.Id = _ctx.LongValue("ListPayroll.PayrollList["+ i +"].Id");
				payrollListItem.PersonSocialInsurance = _ctx.StringValue("ListPayroll.PayrollList["+ i +"].PersonSocialInsurance");

				listPayrollResponse_payrollList.Add(payrollListItem);
			}
			listPayrollResponse.PayrollList = listPayrollResponse_payrollList;
        
			return listPayrollResponse;
        }
    }
}
