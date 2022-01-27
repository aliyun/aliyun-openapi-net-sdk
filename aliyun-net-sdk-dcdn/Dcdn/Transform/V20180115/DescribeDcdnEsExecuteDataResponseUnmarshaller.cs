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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnEsExecuteDataResponseUnmarshaller
    {
        public static DescribeDcdnEsExecuteDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnEsExecuteDataResponse describeDcdnEsExecuteDataResponse = new DescribeDcdnEsExecuteDataResponse();

			describeDcdnEsExecuteDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnEsExecuteDataResponse.RequestId = _ctx.StringValue("DescribeDcdnEsExecuteData.RequestId");

			List<DescribeDcdnEsExecuteDataResponse.DescribeDcdnEsExecuteData_Content> describeDcdnEsExecuteDataResponse_contents = new List<DescribeDcdnEsExecuteDataResponse.DescribeDcdnEsExecuteData_Content>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnEsExecuteData.Contents.Length"); i++) {
				DescribeDcdnEsExecuteDataResponse.DescribeDcdnEsExecuteData_Content content = new DescribeDcdnEsExecuteDataResponse.DescribeDcdnEsExecuteData_Content();
				content.Name = _ctx.StringValue("DescribeDcdnEsExecuteData.Contents["+ i +"].Name");

				List<string> content_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnEsExecuteData.Contents["+ i +"].Columns.Length"); j++) {
					content_columns.Add(_ctx.StringValue("DescribeDcdnEsExecuteData.Contents["+ i +"].Columns["+ j +"]"));
				}
				content.Columns = content_columns;

				List<string> content_points = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnEsExecuteData.Contents["+ i +"].Points.Length"); j++) {
					content_points.Add(_ctx.StringValue("DescribeDcdnEsExecuteData.Contents["+ i +"].Points["+ j +"]"));
				}
				content.Points = content_points;

				describeDcdnEsExecuteDataResponse_contents.Add(content);
			}
			describeDcdnEsExecuteDataResponse.Contents = describeDcdnEsExecuteDataResponse_contents;
        
			return describeDcdnEsExecuteDataResponse;
        }
    }
}
