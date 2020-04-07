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
using Aliyun.Acs.companyreg.Model.V20190508;

namespace Aliyun.Acs.companyreg.Transform.V20190508
{
    public class ListBookkeepingStatisticsesResponseUnmarshaller
    {
        public static ListBookkeepingStatisticsesResponse Unmarshall(UnmarshallerContext context)
        {
			ListBookkeepingStatisticsesResponse listBookkeepingStatisticsesResponse = new ListBookkeepingStatisticsesResponse();

			listBookkeepingStatisticsesResponse.HttpResponse = context.HttpResponse;
			listBookkeepingStatisticsesResponse.RequestId = context.StringValue("ListBookkeepingStatisticses.RequestId");
			listBookkeepingStatisticsesResponse.TotalCount = context.IntegerValue("ListBookkeepingStatisticses.TotalCount");
			listBookkeepingStatisticsesResponse.PageSize = context.IntegerValue("ListBookkeepingStatisticses.PageSize");
			listBookkeepingStatisticsesResponse.PageNumber = context.IntegerValue("ListBookkeepingStatisticses.PageNumber");
			listBookkeepingStatisticsesResponse.IncomeSum = context.FloatValue("ListBookkeepingStatisticses.IncomeSum");
			listBookkeepingStatisticsesResponse.ExpendSum = context.FloatValue("ListBookkeepingStatisticses.ExpendSum");
			listBookkeepingStatisticsesResponse.ProfitSum = context.FloatValue("ListBookkeepingStatisticses.ProfitSum");
			listBookkeepingStatisticsesResponse.TaxAmountSum = context.FloatValue("ListBookkeepingStatisticses.TaxAmountSum");

			List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics> listBookkeepingStatisticsesResponse_bookkeepingStatisticses = new List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics>();
			for (int i = 0; i < context.Length("ListBookkeepingStatisticses.BookkeepingStatisticses.Length"); i++) {
				ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics bookkeepingStatistics = new ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics();
				bookkeepingStatistics.ProduceBizId = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].ProduceBizId");
				bookkeepingStatistics.Year = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Year");
				bookkeepingStatistics.Month = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Month");
				bookkeepingStatistics.Income = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Income");
				bookkeepingStatistics.Expend = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Expend");
				bookkeepingStatistics.Profit = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Profit");
				bookkeepingStatistics.TaxAmount = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxAmount");
				bookkeepingStatistics.TaxZzs = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxZzs");
				bookkeepingStatistics.TaxFjs = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxFjs");
				bookkeepingStatistics.TaxQysds = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxQysds");
				bookkeepingStatistics.TaxYhs = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxYhs");
				bookkeepingStatistics.TaxGhjf = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxGhjf");
				bookkeepingStatistics.TaxSljj = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxSljj");
				bookkeepingStatistics.TaxCjrbzj = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxCjrbzj");
				bookkeepingStatistics.TaxOther = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxOther");
				bookkeepingStatistics.TaxAmountNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxAmountNote");
				bookkeepingStatistics.TaxZzsNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxZzsNote");
				bookkeepingStatistics.TaxFjsNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxFjsNote");
				bookkeepingStatistics.TaxQysdsNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxQysdsNote");
				bookkeepingStatistics.TaxYhsNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxYhsNote");
				bookkeepingStatistics.TaxGhjfNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxGhjfNote");
				bookkeepingStatistics.TaxSljjNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxSljjNote");
				bookkeepingStatistics.TaxCjrbzjNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxCjrbzjNote");
				bookkeepingStatistics.TaxOtherNote = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxOtherNote");
				bookkeepingStatistics.VoucherCount = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].VoucherCount");
				bookkeepingStatistics.SubjectCount = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].SubjectCount");

				List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail> bookkeepingStatistics_taxDetails = new List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail>();
				for (int j = 0; j < context.Length("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails.Length"); j++) {
					ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail taxDetail = new ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail();
					taxDetail.TaxName = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].TaxName");
					taxDetail.Year = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Year");
					taxDetail.Month = context.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Month");
					taxDetail.Amount = context.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Amount");
					taxDetail.Remark = context.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Remark");

					bookkeepingStatistics_taxDetails.Add(taxDetail);
				}
				bookkeepingStatistics.TaxDetails = bookkeepingStatistics_taxDetails;

				listBookkeepingStatisticsesResponse_bookkeepingStatisticses.Add(bookkeepingStatistics);
			}
			listBookkeepingStatisticsesResponse.BookkeepingStatisticses = listBookkeepingStatisticsesResponse_bookkeepingStatisticses;
        
			return listBookkeepingStatisticsesResponse;
        }
    }
}
