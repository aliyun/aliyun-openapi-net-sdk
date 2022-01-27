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
    public class ListVoucherResponseUnmarshaller
    {
        public static ListVoucherResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVoucherResponse listVoucherResponse = new ListVoucherResponse();

			listVoucherResponse.HttpResponse = _ctx.HttpResponse;
			listVoucherResponse.PageCount = _ctx.IntegerValue("ListVoucher.PageCount");
			listVoucherResponse.PageSize = _ctx.IntegerValue("ListVoucher.PageSize");
			listVoucherResponse.RequestId = _ctx.StringValue("ListVoucher.RequestId");
			listVoucherResponse.TotalCount = _ctx.IntegerValue("ListVoucher.TotalCount");

			List<ListVoucherResponse.ListVoucher_ResultItem> listVoucherResponse_result = new List<ListVoucherResponse.ListVoucher_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListVoucher.Result.Length"); i++) {
				ListVoucherResponse.ListVoucher_ResultItem resultItem = new ListVoucherResponse.ListVoucher_ResultItem();
				resultItem.CreatedStamp = _ctx.LongValue("ListVoucher.Result["+ i +"].CreatedStamp");
				resultItem.HasEditAuthority = _ctx.BooleanValue("ListVoucher.Result["+ i +"].HasEditAuthority");
				resultItem.Id = _ctx.LongValue("ListVoucher.Result["+ i +"].Id");
				resultItem.Period = _ctx.StringValue("ListVoucher.Result["+ i +"].Period");
				resultItem.RefVoucherIds = _ctx.StringValue("ListVoucher.Result["+ i +"].RefVoucherIds");
				resultItem.RefVoucherInfo = _ctx.StringValue("ListVoucher.Result["+ i +"].RefVoucherInfo");
				resultItem.UploadAttachmentCount = _ctx.IntegerValue("ListVoucher.Result["+ i +"].UploadAttachmentCount");
				resultItem.VoucherDate = _ctx.LongValue("ListVoucher.Result["+ i +"].VoucherDate");
				resultItem.VoucherNo = _ctx.StringValue("ListVoucher.Result["+ i +"].VoucherNo");
				resultItem.VoucherType = _ctx.StringValue("ListVoucher.Result["+ i +"].VoucherType");
				resultItem.WrittenPerson = _ctx.StringValue("ListVoucher.Result["+ i +"].WrittenPerson");

				ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_ExtAttributes extAttributes = new ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_ExtAttributes();
				extAttributes.IsSupervisor = _ctx.IntegerValue("ListVoucher.Result["+ i +"].ExtAttributes.IsSupervisor");
				extAttributes.NeedCheckCreatorId = _ctx.IntegerValue("ListVoucher.Result["+ i +"].ExtAttributes.NeedCheckCreatorId");
				extAttributes.UpdateAttachment = _ctx.IntegerValue("ListVoucher.Result["+ i +"].ExtAttributes.UpdateAttachment");
				resultItem.ExtAttributes = extAttributes;

				ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_VoucherTransCategoryId voucherTransCategoryId = new ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_VoucherTransCategoryId();
				voucherTransCategoryId.Name = _ctx.StringValue("ListVoucher.Result["+ i +"].VoucherTransCategoryId.Name");
				resultItem.VoucherTransCategoryId = voucherTransCategoryId;

				List<ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_DetailsItem> resultItem_details = new List<ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_DetailsItem>();
				for (int j = 0; j < _ctx.Length("ListVoucher.Result["+ i +"].Details.Length"); j++) {
					ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_DetailsItem detailsItem = new ListVoucherResponse.ListVoucher_ResultItem.ListVoucher_DetailsItem();
					detailsItem.BasePostedCreditor = _ctx.FloatValue("ListVoucher.Result["+ i +"].Details["+ j +"].BasePostedCreditor");
					detailsItem.BasePostedDebtor = _ctx.FloatValue("ListVoucher.Result["+ i +"].Details["+ j +"].BasePostedDebtor");
					detailsItem.Comments = _ctx.StringValue("ListVoucher.Result["+ i +"].Details["+ j +"].Comments");

					resultItem_details.Add(detailsItem);
				}
				resultItem.Details = resultItem_details;

				listVoucherResponse_result.Add(resultItem);
			}
			listVoucherResponse.Result = listVoucherResponse_result;
        
			return listVoucherResponse;
        }
    }
}
