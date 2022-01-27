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
using Aliyun.Acs.Cloudauth.Model.V20200618;

namespace Aliyun.Acs.Cloudauth.Transform.V20200618
{
    public class DescribeSmsDetailResponseUnmarshaller
    {
        public static DescribeSmsDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSmsDetailResponse describeSmsDetailResponse = new DescribeSmsDetailResponse();

			describeSmsDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeSmsDetailResponse.RequestId = _ctx.StringValue("DescribeSmsDetail.RequestId");
			describeSmsDetailResponse.Message = _ctx.StringValue("DescribeSmsDetail.Message");
			describeSmsDetailResponse.Code = _ctx.StringValue("DescribeSmsDetail.Code");
			describeSmsDetailResponse.TotalItem = _ctx.IntegerValue("DescribeSmsDetail.TotalItem");
			describeSmsDetailResponse.TotalPage = _ctx.IntegerValue("DescribeSmsDetail.TotalPage");
			describeSmsDetailResponse.CurrentPage = _ctx.IntegerValue("DescribeSmsDetail.CurrentPage");
			describeSmsDetailResponse.PageSize = _ctx.IntegerValue("DescribeSmsDetail.PageSize");

			List<DescribeSmsDetailResponse.DescribeSmsDetail_ItemsItem> describeSmsDetailResponse_items = new List<DescribeSmsDetailResponse.DescribeSmsDetail_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeSmsDetail.Items.Length"); i++) {
				DescribeSmsDetailResponse.DescribeSmsDetail_ItemsItem itemsItem = new DescribeSmsDetailResponse.DescribeSmsDetail_ItemsItem();
				itemsItem.BizId = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].BizId");
				itemsItem.OuterOrderNo = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].OuterOrderNo");
				itemsItem.Content = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].Content");
				itemsItem.ErrorCode = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].ErrorCode");
				itemsItem.ErrorMessage = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].ErrorMessage");
				itemsItem.SmsSize = _ctx.IntegerValue("DescribeSmsDetail.Items["+ i +"].SmsSize");
				itemsItem.Mobile = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].Mobile");
				itemsItem.ReceiveDate = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].ReceiveDate");
				itemsItem.SendDate = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].SendDate");
				itemsItem.SignName = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].SignName");
				itemsItem.TemplateCode = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].TemplateCode");
				itemsItem.TaskDate = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].TaskDate");
				itemsItem.SendStatus = _ctx.StringValue("DescribeSmsDetail.Items["+ i +"].SendStatus");

				describeSmsDetailResponse_items.Add(itemsItem);
			}
			describeSmsDetailResponse.Items = describeSmsDetailResponse_items;
        
			return describeSmsDetailResponse;
        }
    }
}
