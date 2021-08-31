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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetSslCertificateListResponseUnmarshaller
    {
        public static GetSslCertificateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSslCertificateListResponse getSslCertificateListResponse = new GetSslCertificateListResponse();

			getSslCertificateListResponse.HttpResponse = _ctx.HttpResponse;
			getSslCertificateListResponse.RequestId = _ctx.StringValue("GetSslCertificateList.RequestId");
			getSslCertificateListResponse.Code = _ctx.StringValue("GetSslCertificateList.Code");
			getSslCertificateListResponse.Message = _ctx.StringValue("GetSslCertificateList.Message");

			GetSslCertificateListResponse.GetSslCertificateList_Data data = new GetSslCertificateListResponse.GetSslCertificateList_Data();
			data.Total = _ctx.IntegerValue("GetSslCertificateList.Data.Total");

			List<GetSslCertificateListResponse.GetSslCertificateList_Data.GetSslCertificateList_CertificateListItem> data_certificateList = new List<GetSslCertificateListResponse.GetSslCertificateList_Data.GetSslCertificateList_CertificateListItem>();
			for (int i = 0; i < _ctx.Length("GetSslCertificateList.Data.CertificateList.Length"); i++) {
				GetSslCertificateListResponse.GetSslCertificateList_Data.GetSslCertificateList_CertificateListItem certificateListItem = new GetSslCertificateListResponse.GetSslCertificateList_Data.GetSslCertificateList_CertificateListItem();
				certificateListItem.Id = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].Id");
				certificateListItem.Name = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].Name");
				certificateListItem.Issuer = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].Issuer");
				certificateListItem.StartDate = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].StartDate");
				certificateListItem.EndDate = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].EndDate");
				certificateListItem.Expired = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].Expired");
				certificateListItem.DomainNames = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].DomainNames");
				certificateListItem.RegionId = _ctx.StringValue("GetSslCertificateList.Data.CertificateList["+ i +"].RegionId");

				data_certificateList.Add(certificateListItem);
			}
			data.CertificateList = data_certificateList;
			getSslCertificateListResponse.Data = data;
        
			return getSslCertificateListResponse;
        }
    }
}
