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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIpCertificateResponseUnmarshaller
    {
        public static GetOcIpCertificateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpCertificateResponse getOcIpCertificateResponse = new GetOcIpCertificateResponse();

			getOcIpCertificateResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpCertificateResponse.Code = _ctx.StringValue("GetOcIpCertificate.Code");
			getOcIpCertificateResponse.Success = _ctx.BooleanValue("GetOcIpCertificate.Success");
			getOcIpCertificateResponse.Message = _ctx.StringValue("GetOcIpCertificate.Message");
			getOcIpCertificateResponse.TotalNum = _ctx.IntegerValue("GetOcIpCertificate.TotalNum");
			getOcIpCertificateResponse.PageIndex = _ctx.IntegerValue("GetOcIpCertificate.PageIndex");
			getOcIpCertificateResponse.PageNum = _ctx.IntegerValue("GetOcIpCertificate.PageNum");
			getOcIpCertificateResponse.RequestId = _ctx.StringValue("GetOcIpCertificate.RequestId");

			List<GetOcIpCertificateResponse.GetOcIpCertificate_DataItem> getOcIpCertificateResponse_data = new List<GetOcIpCertificateResponse.GetOcIpCertificate_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpCertificate.Data.Length"); i++) {
				GetOcIpCertificateResponse.GetOcIpCertificate_DataItem dataItem = new GetOcIpCertificateResponse.GetOcIpCertificate_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].EntName");
				dataItem.CertType = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].CertType");
				dataItem.CertNum = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].CertNum");
				dataItem.ValidStartDate = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].ValidStartDate");
				dataItem.ValidEndDate = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].ValidEndDate");
				dataItem.AuthorizeDate = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].AuthorizeDate");
				dataItem.AuthorizeDepartment = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].AuthorizeDepartment");
				dataItem.PubDate = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].PubDate");
				dataItem.Province = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].Province");
				dataItem.CertScope = _ctx.StringValue("GetOcIpCertificate.Data["+ i +"].CertScope");

				getOcIpCertificateResponse_data.Add(dataItem);
			}
			getOcIpCertificateResponse.Data = getOcIpCertificateResponse_data;
        
			return getOcIpCertificateResponse;
        }
    }
}
