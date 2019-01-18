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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class EvaluateFailOverSwitchResponseUnmarshaller
    {
        public static EvaluateFailOverSwitchResponse Unmarshall(UnmarshallerContext context)
        {
			EvaluateFailOverSwitchResponse evaluateFailOverSwitchResponse = new EvaluateFailOverSwitchResponse();

			evaluateFailOverSwitchResponse.HttpResponse = context.HttpResponse;
			evaluateFailOverSwitchResponse.RequestId = context.StringValue("EvaluateFailOverSwitch.RequestId");
			evaluateFailOverSwitchResponse.ReplicaId = context.StringValue("EvaluateFailOverSwitch.ReplicaId");
			evaluateFailOverSwitchResponse.EvaluateResult = context.StringValue("EvaluateFailOverSwitch.EvaluateResult");

			List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem> evaluateFailOverSwitchResponse_items = new List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem>();
			for (int i = 0; i < context.Length("EvaluateFailOverSwitch.Items.Length"); i++) {
				EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem itemsItem = new EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem();
				itemsItem.DBInstanceId = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].DBInstanceId");
				itemsItem.RegionId = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].RegionId");
				itemsItem.ReadWriteType = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].ReadWriteType");
				itemsItem.InstanceNetworkType = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].InstanceNetworkType");
				itemsItem.SecurityIPList = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].SecurityIPList");
				itemsItem.HasInternetIP = context.BooleanValue("EvaluateFailOverSwitch.Items["+ i +"].HasInternetIP");
				itemsItem.InternetIP = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].InternetIP");

				List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem.EvaluateFailOverSwitch_AccountsItem> itemsItem_accounts = new List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem.EvaluateFailOverSwitch_AccountsItem>();
				for (int j = 0; j < context.Length("EvaluateFailOverSwitch.Items["+ i +"].Accounts.Length"); j++) {
					EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem.EvaluateFailOverSwitch_AccountsItem accountsItem = new EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ItemsItem.EvaluateFailOverSwitch_AccountsItem();
					accountsItem.AccountPrivilege = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountPrivilege");
					accountsItem.AccountStatus = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountStatus");
					accountsItem.AccountPrivilegeDetail = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountPrivilegeDetail");
					accountsItem.AccountDescription = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountDescription");
					accountsItem.AccountID = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountID");
					accountsItem.AccountName = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountName");
					accountsItem.PrivExceeded = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].PrivExceeded");
					accountsItem.Engine = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].Engine");
					accountsItem.AccountType = context.StringValue("EvaluateFailOverSwitch.Items["+ i +"].Accounts["+ j +"].AccountType");

					itemsItem_accounts.Add(accountsItem);
				}
				itemsItem.Accounts = itemsItem_accounts;

				evaluateFailOverSwitchResponse_items.Add(itemsItem);
			}
			evaluateFailOverSwitchResponse.Items = evaluateFailOverSwitchResponse_items;

			List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ReportsItem> evaluateFailOverSwitchResponse_reports = new List<EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ReportsItem>();
			for (int i = 0; i < context.Length("EvaluateFailOverSwitch.Reports.Length"); i++) {
				EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ReportsItem reportsItem = new EvaluateFailOverSwitchResponse.EvaluateFailOverSwitch_ReportsItem();
				reportsItem.CheckType = context.StringValue("EvaluateFailOverSwitch.Reports["+ i +"].CheckType");
				reportsItem.Severity = context.StringValue("EvaluateFailOverSwitch.Reports["+ i +"].Severity");
				reportsItem.ReasonCode = context.StringValue("EvaluateFailOverSwitch.Reports["+ i +"].ReasonCode");
				reportsItem.ReasonMessage = context.StringValue("EvaluateFailOverSwitch.Reports["+ i +"].ReasonMessage");

				evaluateFailOverSwitchResponse_reports.Add(reportsItem);
			}
			evaluateFailOverSwitchResponse.Reports = evaluateFailOverSwitchResponse_reports;
        
			return evaluateFailOverSwitchResponse;
        }
    }
}