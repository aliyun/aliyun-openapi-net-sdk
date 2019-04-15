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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSuspiciousExportInfoResponseUnmarshaller
    {
        public static DescribeSuspiciousExportInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspiciousExportInfoResponse describeSuspiciousExportInfoResponse = new DescribeSuspiciousExportInfoResponse();

			describeSuspiciousExportInfoResponse.HttpResponse = context.HttpResponse;
			describeSuspiciousExportInfoResponse.RequestId = context.StringValue("DescribeSuspiciousExportInfo.RequestId");
			describeSuspiciousExportInfoResponse.Id = context.IntegerValue("DescribeSuspiciousExportInfo.Id");
			describeSuspiciousExportInfoResponse.GmtCreate = context.LongValue("DescribeSuspiciousExportInfo.GmtCreate");
			describeSuspiciousExportInfoResponse.FileName = context.StringValue("DescribeSuspiciousExportInfo.FileName");
			describeSuspiciousExportInfoResponse.CurrentCount = context.IntegerValue("DescribeSuspiciousExportInfo.CurrentCount");
			describeSuspiciousExportInfoResponse.TotalCount = context.IntegerValue("DescribeSuspiciousExportInfo.TotalCount");
			describeSuspiciousExportInfoResponse.Progress = context.IntegerValue("DescribeSuspiciousExportInfo.Progress");
			describeSuspiciousExportInfoResponse.ExportStatus = context.StringValue("DescribeSuspiciousExportInfo.ExportStatus");
			describeSuspiciousExportInfoResponse.Message = context.StringValue("DescribeSuspiciousExportInfo.Message");
			describeSuspiciousExportInfoResponse.Link = context.StringValue("DescribeSuspiciousExportInfo.Link");
        
			return describeSuspiciousExportInfoResponse;
        }
    }
}
