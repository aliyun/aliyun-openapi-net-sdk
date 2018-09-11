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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class EvaluateFailoverResponseUnmarshaller
    {
        public static EvaluateFailoverResponse Unmarshall(UnmarshallerContext context)
        {
			EvaluateFailoverResponse evaluateFailoverResponse = new EvaluateFailoverResponse();

			evaluateFailoverResponse.HttpResponse = context.HttpResponse;
			evaluateFailoverResponse.RequestId = context.StringValue("EvaluateFailover.RequestId");
			evaluateFailoverResponse.ReplicaId = context.StringValue("EvaluateFailover.ReplicaId");
			evaluateFailoverResponse.EvaluateResult = context.StringValue("EvaluateFailover.EvaluateResult");

			List<EvaluateFailoverResponse.EvaluateFailover_ItemsItem> evaluateFailoverResponse_items = new List<EvaluateFailoverResponse.EvaluateFailover_ItemsItem>();
			for (int i = 0; i < context.Length("EvaluateFailover.Items.Length"); i++) {
				EvaluateFailoverResponse.EvaluateFailover_ItemsItem itemsItem = new EvaluateFailoverResponse.EvaluateFailover_ItemsItem();
				itemsItem.DBInstanceId = context.StringValue("EvaluateFailover.Items["+ i +"].DBInstanceId");
				itemsItem.RegionId = context.StringValue("EvaluateFailover.Items["+ i +"].RegionId");
				itemsItem.Role = context.StringValue("EvaluateFailover.Items["+ i +"].Role");
				itemsItem.ReadWriteType = context.StringValue("EvaluateFailover.Items["+ i +"].ReadWriteType");
				itemsItem.InstanceNetworkType = context.StringValue("EvaluateFailover.Items["+ i +"].InstanceNetworkType");
				itemsItem.SecurityIPList = context.StringValue("EvaluateFailover.Items["+ i +"].SecurityIPList");
				itemsItem.HasInternetIP = context.BooleanValue("EvaluateFailover.Items["+ i +"].HasInternetIP");
				itemsItem.InternetIP = context.StringValue("EvaluateFailover.Items["+ i +"].InternetIP");

				List<EvaluateFailoverResponse.EvaluateFailover_ItemsItem.EvaluateFailover_AccountsItem> itemsItem_accounts = new List<EvaluateFailoverResponse.EvaluateFailover_ItemsItem.EvaluateFailover_AccountsItem>();
				for (int j = 0; j < context.Length("EvaluateFailover.Items["+ i +"].Accounts.Length"); j++) {
					EvaluateFailoverResponse.EvaluateFailover_ItemsItem.EvaluateFailover_AccountsItem accountsItem = new EvaluateFailoverResponse.EvaluateFailover_ItemsItem.EvaluateFailover_AccountsItem();
					accountsItem.AccountPrivilege = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountPrivilege");
					accountsItem.AccountStatus = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountStatus");
					accountsItem.AccountPrivilegeDetail = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountPrivilegeDetail");
					accountsItem.AccountDescription = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountDescription");
					accountsItem.AccountID = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountID");
					accountsItem.AccountName = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountName");
					accountsItem.PrivExceeded = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].PrivExceeded");
					accountsItem.Engine = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].Engine");
					accountsItem.AccountType = context.StringValue("EvaluateFailover.Items["+ i +"].Accounts["+ j +"].AccountType");

					itemsItem_accounts.Add(accountsItem);
				}
				itemsItem.Accounts = itemsItem_accounts;

				evaluateFailoverResponse_items.Add(itemsItem);
			}
			evaluateFailoverResponse.Items = evaluateFailoverResponse_items;

			List<EvaluateFailoverResponse.EvaluateFailover_ReportsItem> evaluateFailoverResponse_reports = new List<EvaluateFailoverResponse.EvaluateFailover_ReportsItem>();
			for (int i = 0; i < context.Length("EvaluateFailover.Reports.Length"); i++) {
				EvaluateFailoverResponse.EvaluateFailover_ReportsItem reportsItem = new EvaluateFailoverResponse.EvaluateFailover_ReportsItem();
				reportsItem.CheckType = context.StringValue("EvaluateFailover.Reports["+ i +"].CheckType");
				reportsItem.Severity = context.StringValue("EvaluateFailover.Reports["+ i +"].Severity");
				reportsItem.ReasonCode = context.StringValue("EvaluateFailover.Reports["+ i +"].ReasonCode");
				reportsItem.ReasonMessage = context.StringValue("EvaluateFailover.Reports["+ i +"].ReasonMessage");

				evaluateFailoverResponse_reports.Add(reportsItem);
			}
			evaluateFailoverResponse.Reports = evaluateFailoverResponse_reports;
        
			return evaluateFailoverResponse;
        }
    }
}