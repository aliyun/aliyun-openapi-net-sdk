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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDataExportDownloadURLResponseUnmarshaller
    {
        public static GetDataExportDownloadURLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataExportDownloadURLResponse getDataExportDownloadURLResponse = new GetDataExportDownloadURLResponse();

			getDataExportDownloadURLResponse.HttpResponse = _ctx.HttpResponse;
			getDataExportDownloadURLResponse.RequestId = _ctx.StringValue("GetDataExportDownloadURL.RequestId");
			getDataExportDownloadURLResponse.ErrorCode = _ctx.StringValue("GetDataExportDownloadURL.ErrorCode");
			getDataExportDownloadURLResponse.ErrorMessage = _ctx.StringValue("GetDataExportDownloadURL.ErrorMessage");
			getDataExportDownloadURLResponse.Success = _ctx.BooleanValue("GetDataExportDownloadURL.Success");

			GetDataExportDownloadURLResponse.GetDataExportDownloadURL_DownloadURLResult downloadURLResult = new GetDataExportDownloadURLResponse.GetDataExportDownloadURL_DownloadURLResult();
			downloadURLResult.HasResult = _ctx.BooleanValue("GetDataExportDownloadURL.DownloadURLResult.HasResult");
			downloadURLResult.TipMessage = _ctx.StringValue("GetDataExportDownloadURL.DownloadURLResult.TipMessage");
			downloadURLResult.URL = _ctx.StringValue("GetDataExportDownloadURL.DownloadURLResult.URL");
			getDataExportDownloadURLResponse.DownloadURLResult = downloadURLResult;
        
			return getDataExportDownloadURLResponse;
        }
    }
}
