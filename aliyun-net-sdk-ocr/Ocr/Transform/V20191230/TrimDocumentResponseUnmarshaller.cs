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
using Aliyun.Acs.ocr.Model.V20191230;

namespace Aliyun.Acs.ocr.Transform.V20191230
{
    public class TrimDocumentResponseUnmarshaller
    {
        public static TrimDocumentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TrimDocumentResponse trimDocumentResponse = new TrimDocumentResponse();

			trimDocumentResponse.HttpResponse = _ctx.HttpResponse;
			trimDocumentResponse.RequestId = _ctx.StringValue("TrimDocument.RequestId");

			TrimDocumentResponse.TrimDocument_Data data = new TrimDocumentResponse.TrimDocument_Data();
			data.Content = _ctx.StringValue("TrimDocument.Data.Content");
			trimDocumentResponse.Data = data;
        
			return trimDocumentResponse;
        }
    }
}
