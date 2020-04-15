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
    public class DescirbeCombineTrademarkResponseUnmarshaller
    {
        public static DescirbeCombineTrademarkResponse Unmarshall(UnmarshallerContext context)
        {
			DescirbeCombineTrademarkResponse descirbeCombineTrademarkResponse = new DescirbeCombineTrademarkResponse();

			descirbeCombineTrademarkResponse.HttpResponse = context.HttpResponse;
			descirbeCombineTrademarkResponse.RequestId = context.StringValue("DescirbeCombineTrademark.RequestId");
			descirbeCombineTrademarkResponse.TotalItemNumber = context.IntegerValue("DescirbeCombineTrademark.TotalItemNumber");
			descirbeCombineTrademarkResponse.CurrentPageNumber = context.IntegerValue("DescirbeCombineTrademark.CurrentPageNumber");
			descirbeCombineTrademarkResponse.PageSize = context.IntegerValue("DescirbeCombineTrademark.PageSize");
			descirbeCombineTrademarkResponse.TotalPageNumber = context.IntegerValue("DescirbeCombineTrademark.TotalPageNumber");
			descirbeCombineTrademarkResponse.PrePage = context.BooleanValue("DescirbeCombineTrademark.PrePage");
			descirbeCombineTrademarkResponse.NextPage = context.BooleanValue("DescirbeCombineTrademark.NextPage");

			List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark> descirbeCombineTrademarkResponse_data = new List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark>();
			for (int i = 0; i < context.Length("DescirbeCombineTrademark.Data.Length"); i++) {
				DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark trademark = new DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark();
				trademark.IndexId = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].IndexId");
				trademark.Name = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Name");
				trademark.RegistrationNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].RegistrationNumber");
				trademark.Classification = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Classification");
				trademark.ApplyDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].ApplyDate");
				trademark.OwnerName = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].OwnerName");
				trademark.OwnerEnName = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].OwnerEnName");
				trademark.Image = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Image");
				trademark.PreAnnNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].PreAnnNumber");
				trademark.RegAnnNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].RegAnnNumber");
				trademark.PreAnnDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].PreAnnDate");
				trademark.RegAnnDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].RegAnnDate");
				trademark.LawFinalStatus = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].LawFinalStatus");
				trademark.LastProcedureStatus = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].LastProcedureStatus");
				trademark.Share = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Share");
				trademark.OwnerAddress = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].OwnerAddress");
				trademark.OwnerEnAddress = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].OwnerEnAddress");
				trademark.ExclusiveDateLimit = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].ExclusiveDateLimit");
				trademark.Agency = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Agency");
				trademark.ProductDescription = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].ProductDescription");
				trademark.SimilarGroup = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].SimilarGroup");
				trademark.RegistrationType = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].RegistrationType");
				trademark.OnSale = context.IntegerValue("DescirbeCombineTrademark.Data["+ i +"].OnSale");
				trademark.Status = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Status");
				trademark.PriorityDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].PriorityDate");
				trademark.IntlRegDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].IntlRegDate");
				trademark.SubsequentDesignationDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].SubsequentDesignationDate");
				trademark.FirstAnnoNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].FirstAnnoNumber");
				trademark.FirstAnnoType = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].FirstAnnoType");
				trademark.SecondAnnoNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].SecondAnnoNumber");
				trademark.SecondAnnoType = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].SecondAnnoType");

				List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_AnnouncementListItem> trademark_announcementList = new List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_AnnouncementListItem>();
				for (int j = 0; j < context.Length("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList.Length"); j++) {
					DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_AnnouncementListItem announcementListItem = new DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_AnnouncementListItem();
					announcementListItem.AnnNumber = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].AnnNumber");
					announcementListItem.AnnTypeCode = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].AnnTypeCode");
					announcementListItem.AnnTypeName = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].AnnTypeName");
					announcementListItem.AnnDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].AnnDate");
					announcementListItem.ImageUrl = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].ImageUrl");
					announcementListItem.OriginalImageUrl = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].AnnouncementList["+ j +"].OriginalImageUrl");

					trademark_announcementList.Add(announcementListItem);
				}
				trademark.AnnouncementList = trademark_announcementList;

				List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_ProcedureList> trademark_procedures = new List<DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_ProcedureList>();
				for (int j = 0; j < context.Length("DescirbeCombineTrademark.Data["+ i +"].Procedures.Length"); j++) {
					DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_ProcedureList procedureList = new DescirbeCombineTrademarkResponse.DescirbeCombineTrademark_Trademark.DescirbeCombineTrademark_ProcedureList();
					procedureList.ProcedureCode = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Procedures["+ j +"].ProcedureCode");
					procedureList.ProcedureName = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Procedures["+ j +"].ProcedureName");
					procedureList.ProcedureStep = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Procedures["+ j +"].ProcedureStep");
					procedureList.ProcedureResult = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Procedures["+ j +"].ProcedureResult");
					procedureList.ProcedureDate = context.StringValue("DescirbeCombineTrademark.Data["+ i +"].Procedures["+ j +"].ProcedureDate");

					trademark_procedures.Add(procedureList);
				}
				trademark.Procedures = trademark_procedures;

				descirbeCombineTrademarkResponse_data.Add(trademark);
			}
			descirbeCombineTrademarkResponse.Data = descirbeCombineTrademarkResponse_data;
        
			return descirbeCombineTrademarkResponse;
        }
    }
}
