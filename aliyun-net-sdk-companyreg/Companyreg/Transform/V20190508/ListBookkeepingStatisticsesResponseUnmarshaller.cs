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
        public static ListBookkeepingStatisticsesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBookkeepingStatisticsesResponse listBookkeepingStatisticsesResponse = new ListBookkeepingStatisticsesResponse();

			listBookkeepingStatisticsesResponse.HttpResponse = _ctx.HttpResponse;
			listBookkeepingStatisticsesResponse.RequestId = _ctx.StringValue("ListBookkeepingStatisticses.RequestId");
			listBookkeepingStatisticsesResponse.TotalCount = _ctx.IntegerValue("ListBookkeepingStatisticses.TotalCount");
			listBookkeepingStatisticsesResponse.PageSize = _ctx.IntegerValue("ListBookkeepingStatisticses.PageSize");
			listBookkeepingStatisticsesResponse.PageNumber = _ctx.IntegerValue("ListBookkeepingStatisticses.PageNumber");
			listBookkeepingStatisticsesResponse.IncomeSum = _ctx.FloatValue("ListBookkeepingStatisticses.IncomeSum");
			listBookkeepingStatisticsesResponse.ExpendSum = _ctx.FloatValue("ListBookkeepingStatisticses.ExpendSum");
			listBookkeepingStatisticsesResponse.ProfitSum = _ctx.FloatValue("ListBookkeepingStatisticses.ProfitSum");
			listBookkeepingStatisticsesResponse.TaxAmountSum = _ctx.FloatValue("ListBookkeepingStatisticses.TaxAmountSum");

			List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics> listBookkeepingStatisticsesResponse_bookkeepingStatisticses = new List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics>();
			for (int i = 0; i < _ctx.Length("ListBookkeepingStatisticses.BookkeepingStatisticses.Length"); i++) {
				ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics bookkeepingStatistics = new ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics();
				bookkeepingStatistics.ProduceBizId = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].ProduceBizId");
				bookkeepingStatistics.Year = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Year");
				bookkeepingStatistics.Month = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Month");
				bookkeepingStatistics.Income = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Income");
				bookkeepingStatistics.Expend = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Expend");
				bookkeepingStatistics.Profit = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].Profit");
				bookkeepingStatistics.TaxAmount = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxAmount");
				bookkeepingStatistics.TaxZzs = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxZzs");
				bookkeepingStatistics.TaxFjs = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxFjs");
				bookkeepingStatistics.TaxQysds = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxQysds");
				bookkeepingStatistics.TaxYhs = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxYhs");
				bookkeepingStatistics.TaxGhjf = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxGhjf");
				bookkeepingStatistics.TaxSljj = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxSljj");
				bookkeepingStatistics.TaxCjrbzj = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxCjrbzj");
				bookkeepingStatistics.TaxOther = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxOther");
				bookkeepingStatistics.TaxAmountNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxAmountNote");
				bookkeepingStatistics.TaxZzsNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxZzsNote");
				bookkeepingStatistics.TaxFjsNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxFjsNote");
				bookkeepingStatistics.TaxQysdsNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxQysdsNote");
				bookkeepingStatistics.TaxYhsNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxYhsNote");
				bookkeepingStatistics.TaxGhjfNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxGhjfNote");
				bookkeepingStatistics.TaxSljjNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxSljjNote");
				bookkeepingStatistics.TaxCjrbzjNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxCjrbzjNote");
				bookkeepingStatistics.TaxOtherNote = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxOtherNote");
				bookkeepingStatistics.VoucherCount = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].VoucherCount");
				bookkeepingStatistics.SubjectCount = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].SubjectCount");

				List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail> bookkeepingStatistics_taxDetails = new List<ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail>();
				for (int j = 0; j < _ctx.Length("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails.Length"); j++) {
					ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail taxDetail = new ListBookkeepingStatisticsesResponse.ListBookkeepingStatisticses_BookkeepingStatistics.ListBookkeepingStatisticses_TaxDetail();
					taxDetail.TaxName = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].TaxName");
					taxDetail.Year = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Year");
					taxDetail.Month = _ctx.IntegerValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Month");
					taxDetail.Amount = _ctx.FloatValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Amount");
					taxDetail.Remark = _ctx.StringValue("ListBookkeepingStatisticses.BookkeepingStatisticses["+ i +"].TaxDetails["+ j +"].Remark");

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
