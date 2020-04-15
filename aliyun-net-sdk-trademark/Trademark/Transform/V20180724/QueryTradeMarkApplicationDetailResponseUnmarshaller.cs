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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTradeMarkApplicationDetailResponseUnmarshaller
    {
        public static QueryTradeMarkApplicationDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeMarkApplicationDetailResponse queryTradeMarkApplicationDetailResponse = new QueryTradeMarkApplicationDetailResponse();

			queryTradeMarkApplicationDetailResponse.HttpResponse = context.HttpResponse;
			queryTradeMarkApplicationDetailResponse.Status = context.IntegerValue("QueryTradeMarkApplicationDetail.Status");
			queryTradeMarkApplicationDetailResponse.RequestId = context.StringValue("QueryTradeMarkApplicationDetail.RequestId");
			queryTradeMarkApplicationDetailResponse.LoaUrl = context.StringValue("QueryTradeMarkApplicationDetail.LoaUrl");
			queryTradeMarkApplicationDetailResponse.OrderPrice = context.FloatValue("QueryTradeMarkApplicationDetail.OrderPrice");
			queryTradeMarkApplicationDetailResponse.TmIcon = context.StringValue("QueryTradeMarkApplicationDetail.TmIcon");
			queryTradeMarkApplicationDetailResponse.OrderId = context.StringValue("QueryTradeMarkApplicationDetail.OrderId");
			queryTradeMarkApplicationDetailResponse.Type = context.IntegerValue("QueryTradeMarkApplicationDetail.Type");
			queryTradeMarkApplicationDetailResponse.TmNameType = context.IntegerValue("QueryTradeMarkApplicationDetail.TmNameType");
			queryTradeMarkApplicationDetailResponse.TmName = context.StringValue("QueryTradeMarkApplicationDetail.TmName");
			queryTradeMarkApplicationDetailResponse.BizId = context.StringValue("QueryTradeMarkApplicationDetail.BizId");
			queryTradeMarkApplicationDetailResponse.GrayIconUrl = context.StringValue("QueryTradeMarkApplicationDetail.GrayIconUrl");
			queryTradeMarkApplicationDetailResponse.Note = context.StringValue("QueryTradeMarkApplicationDetail.Note");
			queryTradeMarkApplicationDetailResponse.TmNumber = context.StringValue("QueryTradeMarkApplicationDetail.TmNumber");
			queryTradeMarkApplicationDetailResponse.AcceptUrl = context.StringValue("QueryTradeMarkApplicationDetail.AcceptUrl");
			queryTradeMarkApplicationDetailResponse.CreateTime = context.LongValue("QueryTradeMarkApplicationDetail.CreateTime");
			queryTradeMarkApplicationDetailResponse.UpdateTime = context.LongValue("QueryTradeMarkApplicationDetail.UpdateTime");
			queryTradeMarkApplicationDetailResponse.ExtendInfo = context.StringValue("QueryTradeMarkApplicationDetail.ExtendInfo");
			queryTradeMarkApplicationDetailResponse.SendSbjLogistics = context.StringValue("QueryTradeMarkApplicationDetail.SendSbjLogistics");
			queryTradeMarkApplicationDetailResponse.SendUserLogistics = context.StringValue("QueryTradeMarkApplicationDetail.SendUserLogistics");
			queryTradeMarkApplicationDetailResponse.RecvUserLogistics = context.StringValue("QueryTradeMarkApplicationDetail.RecvUserLogistics");
			queryTradeMarkApplicationDetailResponse.MaterialId = context.LongValue("QueryTradeMarkApplicationDetail.MaterialId");
			queryTradeMarkApplicationDetailResponse.TotalPrice = context.FloatValue("QueryTradeMarkApplicationDetail.TotalPrice");
			queryTradeMarkApplicationDetailResponse.ServicePrice = context.FloatValue("QueryTradeMarkApplicationDetail.ServicePrice");
			queryTradeMarkApplicationDetailResponse.PartnerCode = context.StringValue("QueryTradeMarkApplicationDetail.PartnerCode");
			queryTradeMarkApplicationDetailResponse.PartnerMobile = context.StringValue("QueryTradeMarkApplicationDetail.PartnerMobile");
			queryTradeMarkApplicationDetailResponse.NotAcceptUrl = context.StringValue("QueryTradeMarkApplicationDetail.NotAcceptUrl");
			queryTradeMarkApplicationDetailResponse.PartnerName = context.StringValue("QueryTradeMarkApplicationDetail.PartnerName");

			List<string> queryTradeMarkApplicationDetailResponse_receiptUrl = new List<string>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.ReceiptUrl.Length"); i++) {
				queryTradeMarkApplicationDetailResponse_receiptUrl.Add(context.StringValue("QueryTradeMarkApplicationDetail.ReceiptUrl["+ i +"]"));
			}
			queryTradeMarkApplicationDetailResponse.ReceiptUrl = queryTradeMarkApplicationDetailResponse_receiptUrl;

			List<string> queryTradeMarkApplicationDetailResponse_judgeResultUrl = new List<string>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.JudgeResultUrl.Length"); i++) {
				queryTradeMarkApplicationDetailResponse_judgeResultUrl.Add(context.StringValue("QueryTradeMarkApplicationDetail.JudgeResultUrl["+ i +"]"));
			}
			queryTradeMarkApplicationDetailResponse.JudgeResultUrl = queryTradeMarkApplicationDetailResponse_judgeResultUrl;

			List<string> queryTradeMarkApplicationDetailResponse_flags = new List<string>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.Flags.Length"); i++) {
				queryTradeMarkApplicationDetailResponse_flags.Add(context.StringValue("QueryTradeMarkApplicationDetail.Flags["+ i +"]"));
			}
			queryTradeMarkApplicationDetailResponse.Flags = queryTradeMarkApplicationDetailResponse_flags;

			QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_AdminUploads adminUploads = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_AdminUploads();
			adminUploads.LoaPicUrl = context.StringValue("QueryTradeMarkApplicationDetail.AdminUploads.LoaPicUrl");
			adminUploads.LicensePicUrl = context.StringValue("QueryTradeMarkApplicationDetail.AdminUploads.LicensePicUrl");
			queryTradeMarkApplicationDetailResponse.AdminUploads = adminUploads;

			QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_MaterialDetail materialDetail = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_MaterialDetail();
			materialDetail.CardNumber = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.CardNumber");
			materialDetail.ContactAddress = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ContactAddress");
			materialDetail.Status = context.IntegerValue("QueryTradeMarkApplicationDetail.MaterialDetail.Status");
			materialDetail.EName = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.EName");
			materialDetail.Address = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.Address");
			materialDetail.LoaUrl = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.LoaUrl");
			materialDetail.City = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.City");
			materialDetail.PassportUrl = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.PassportUrl");
			materialDetail.Province = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.Province");
			materialDetail.EAddress = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.EAddress");
			materialDetail.Name = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.Name");
			materialDetail.IdCardUrl = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.IdCardUrl");
			materialDetail.BusinessLicenceUrl = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.BusinessLicenceUrl");
			materialDetail.Type = context.IntegerValue("QueryTradeMarkApplicationDetail.MaterialDetail.Type");
			materialDetail.ExpirationDate = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ExpirationDate");
			materialDetail.ContactZipcode = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ContactZipcode");
			materialDetail.Town = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.Town");
			materialDetail.ContactNumber = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ContactNumber");
			materialDetail.ContactEmail = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ContactEmail");
			materialDetail.Country = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.Country");
			materialDetail.Region = context.IntegerValue("QueryTradeMarkApplicationDetail.MaterialDetail.Region");
			materialDetail.ContactName = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ContactName");
			materialDetail.LegalNoticeUrl = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.LegalNoticeUrl");
			materialDetail.ReviewApplicationFile = context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ReviewApplicationFile");

			List<string> materialDetail_reviewAdditionalFiles = new List<string>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.MaterialDetail.ReviewAdditionalFiles.Length"); i++) {
				materialDetail_reviewAdditionalFiles.Add(context.StringValue("QueryTradeMarkApplicationDetail.MaterialDetail.ReviewAdditionalFiles["+ i +"]"));
			}
			materialDetail.ReviewAdditionalFiles = materialDetail_reviewAdditionalFiles;
			queryTradeMarkApplicationDetailResponse.MaterialDetail = materialDetail;

			QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_FirstClassification firstClassification = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_FirstClassification();
			firstClassification.Code = context.StringValue("QueryTradeMarkApplicationDetail.FirstClassification.Code");
			firstClassification.Name = context.StringValue("QueryTradeMarkApplicationDetail.FirstClassification.Name");
			queryTradeMarkApplicationDetailResponse.FirstClassification = firstClassification;

			QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_RenewResponse renewResponse = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_RenewResponse();
			renewResponse.Name = context.StringValue("QueryTradeMarkApplicationDetail.RenewResponse.Name");
			renewResponse.EngName = context.StringValue("QueryTradeMarkApplicationDetail.RenewResponse.EngName");
			renewResponse.Address = context.StringValue("QueryTradeMarkApplicationDetail.RenewResponse.Address");
			renewResponse.EngAddress = context.StringValue("QueryTradeMarkApplicationDetail.RenewResponse.EngAddress");
			renewResponse.RegisterTime = context.LongValue("QueryTradeMarkApplicationDetail.RenewResponse.RegisterTime");
			renewResponse.SubmitSbjtime = context.LongValue("QueryTradeMarkApplicationDetail.RenewResponse.SubmitSbjtime");
			queryTradeMarkApplicationDetailResponse.RenewResponse = renewResponse;

			QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ReviewOfficialFiles reviewOfficialFiles = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ReviewOfficialFiles();
			reviewOfficialFiles.ReviewAudit = context.StringValue("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewAudit");
			reviewOfficialFiles.ReviewPass = context.StringValue("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewPass");
			reviewOfficialFiles.ReviewKeep = context.StringValue("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewKeep");
			reviewOfficialFiles.ReviewPart = context.StringValue("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewPart");

			List<string> reviewOfficialFiles_reviewSupplements = new List<string>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewSupplements.Length"); i++) {
				reviewOfficialFiles_reviewSupplements.Add(context.StringValue("QueryTradeMarkApplicationDetail.ReviewOfficialFiles.ReviewSupplements["+ i +"]"));
			}
			reviewOfficialFiles.ReviewSupplements = reviewOfficialFiles_reviewSupplements;
			queryTradeMarkApplicationDetailResponse.ReviewOfficialFiles = reviewOfficialFiles;

			List<QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ThirdClassifications> queryTradeMarkApplicationDetailResponse_thirdClassification = new List<QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ThirdClassifications>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.ThirdClassification.Length"); i++) {
				QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ThirdClassifications thirdClassifications = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_ThirdClassifications();
				thirdClassifications.Code = context.StringValue("QueryTradeMarkApplicationDetail.ThirdClassification["+ i +"].Code");
				thirdClassifications.Name = context.StringValue("QueryTradeMarkApplicationDetail.ThirdClassification["+ i +"].Name");

				queryTradeMarkApplicationDetailResponse_thirdClassification.Add(thirdClassifications);
			}
			queryTradeMarkApplicationDetailResponse.ThirdClassification = queryTradeMarkApplicationDetailResponse_thirdClassification;

			List<QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_SupplementsItem> queryTradeMarkApplicationDetailResponse_supplements = new List<QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_SupplementsItem>();
			for (int i = 0; i < context.Length("QueryTradeMarkApplicationDetail.Supplements.Length"); i++) {
				QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_SupplementsItem supplementsItem = new QueryTradeMarkApplicationDetailResponse.QueryTradeMarkApplicationDetail_SupplementsItem();
				supplementsItem.Id = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].Id");
				supplementsItem.SerialNumber = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].SerialNumber");
				supplementsItem.Type = context.IntegerValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].Type");
				supplementsItem.Status = context.IntegerValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].Status");
				supplementsItem.OrderId = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].OrderId");
				supplementsItem.TmNumber = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].TmNumber");
				supplementsItem.SendTime = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].SendTime");
				supplementsItem.AcceptTime = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].AcceptTime");
				supplementsItem.SbjDeadTime = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].SbjDeadTime");
				supplementsItem.AcceptDeadTime = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].AcceptDeadTime");
				supplementsItem.UploadFileTemplateUrl = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].UploadFileTemplateUrl");
				supplementsItem.Content = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].Content");
				supplementsItem.BatchNum = context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].BatchNum");
				supplementsItem.OperateTime = context.LongValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].OperateTime");

				List<string> supplementsItem_fileTemplateUrls = new List<string>();
				for (int j = 0; j < context.Length("QueryTradeMarkApplicationDetail.Supplements["+ i +"].FileTemplateUrls.Length"); j++) {
					supplementsItem_fileTemplateUrls.Add(context.StringValue("QueryTradeMarkApplicationDetail.Supplements["+ i +"].FileTemplateUrls["+ j +"]"));
				}
				supplementsItem.FileTemplateUrls = supplementsItem_fileTemplateUrls;

				queryTradeMarkApplicationDetailResponse_supplements.Add(supplementsItem);
			}
			queryTradeMarkApplicationDetailResponse.Supplements = queryTradeMarkApplicationDetailResponse_supplements;
        
			return queryTradeMarkApplicationDetailResponse;
        }
    }
}
