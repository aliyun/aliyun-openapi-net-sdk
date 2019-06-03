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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryInvoicingCustomerListResponseUnmarshaller
    {
        public static QueryInvoicingCustomerListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryInvoicingCustomerListResponse queryInvoicingCustomerListResponse = new QueryInvoicingCustomerListResponse();

			queryInvoicingCustomerListResponse.HttpResponse = context.HttpResponse;
			queryInvoicingCustomerListResponse.RequestId = context.StringValue("QueryInvoicingCustomerList.RequestId");
			queryInvoicingCustomerListResponse.Success = context.BooleanValue("QueryInvoicingCustomerList.Success");
			queryInvoicingCustomerListResponse.Code = context.StringValue("QueryInvoicingCustomerList.Code");
			queryInvoicingCustomerListResponse.Message = context.StringValue("QueryInvoicingCustomerList.Message");

			QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data data = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data();

			List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice> data_customerInvoiceList = new List<QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice>();
			for (int i = 0; i < context.Length("QueryInvoicingCustomerList.Data.CustomerInvoiceList.Length"); i++) {
				QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice customerInvoice = new QueryInvoicingCustomerListResponse.QueryInvoicingCustomerList_Data.QueryInvoicingCustomerList_CustomerInvoice();
				customerInvoice.Id = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Id");
				customerInvoice.UserId = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserId");
				customerInvoice.UserNick = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].UserNick");
				customerInvoice.InvoiceTitle = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].InvoiceTitle");
				customerInvoice.CustomerType = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].CustomerType");
				customerInvoice.TaxpayerType = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxpayerType");
				customerInvoice.Bank = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Bank");
				customerInvoice.BankNo = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].BankNo");
				customerInvoice.OperatingLicenseAddress = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicenseAddress");
				customerInvoice.OperatingLicensePhone = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].OperatingLicensePhone");
				customerInvoice.RegisterNo = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].RegisterNo");
				customerInvoice.StartCycle = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].StartCycle");
				customerInvoice.Status = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Status");
				customerInvoice.GmtCreate = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].GmtCreate");
				customerInvoice.TaxationLicense = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TaxationLicense");
				customerInvoice.AdjustType = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].AdjustType");
				customerInvoice.EndCycle = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].EndCycle");
				customerInvoice.TitleChangeInstructions = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].TitleChangeInstructions");
				customerInvoice.IssueType = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].IssueType");
				customerInvoice.Type = context.LongValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].Type");
				customerInvoice.DefaultRemark = context.StringValue("QueryInvoicingCustomerList.Data.CustomerInvoiceList["+ i +"].DefaultRemark");

				data_customerInvoiceList.Add(customerInvoice);
			}
			data.CustomerInvoiceList = data_customerInvoiceList;
			queryInvoicingCustomerListResponse.Data = data;
        
			return queryInvoicingCustomerListResponse;
        }
    }
}
