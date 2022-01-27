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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeSupportLinesResponseUnmarshaller
    {
        public static DescribeSupportLinesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSupportLinesResponse describeSupportLinesResponse = new DescribeSupportLinesResponse();

			describeSupportLinesResponse.HttpResponse = _ctx.HttpResponse;
			describeSupportLinesResponse.RequestId = _ctx.StringValue("DescribeSupportLines.RequestId");

			List<DescribeSupportLinesResponse.DescribeSupportLines_RecordLine> describeSupportLinesResponse_recordLines = new List<DescribeSupportLinesResponse.DescribeSupportLines_RecordLine>();
			for (int i = 0; i < _ctx.Length("DescribeSupportLines.RecordLines.Length"); i++) {
				DescribeSupportLinesResponse.DescribeSupportLines_RecordLine recordLine = new DescribeSupportLinesResponse.DescribeSupportLines_RecordLine();
				recordLine.LineCode = _ctx.StringValue("DescribeSupportLines.RecordLines["+ i +"].LineCode");
				recordLine.FatherCode = _ctx.StringValue("DescribeSupportLines.RecordLines["+ i +"].FatherCode");
				recordLine.LineName = _ctx.StringValue("DescribeSupportLines.RecordLines["+ i +"].LineName");
				recordLine.LineDisplayName = _ctx.StringValue("DescribeSupportLines.RecordLines["+ i +"].LineDisplayName");

				describeSupportLinesResponse_recordLines.Add(recordLine);
			}
			describeSupportLinesResponse.RecordLines = describeSupportLinesResponse_recordLines;
        
			return describeSupportLinesResponse;
        }
    }
}
