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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class FetchLibrariesResponseUnmarshaller
    {
        public static FetchLibrariesResponse Unmarshall(UnmarshallerContext context)
        {
			FetchLibrariesResponse fetchLibrariesResponse = new FetchLibrariesResponse();

			fetchLibrariesResponse.HttpResponse = context.HttpResponse;
			fetchLibrariesResponse.Code = context.StringValue("FetchLibraries.Code");
			fetchLibrariesResponse.Message = context.StringValue("FetchLibraries.Message");
			fetchLibrariesResponse.TotalCount = context.IntegerValue("FetchLibraries.TotalCount");
			fetchLibrariesResponse.RequestId = context.StringValue("FetchLibraries.RequestId");
			fetchLibrariesResponse.Action = context.StringValue("FetchLibraries.Action");

			List<FetchLibrariesResponse.FetchLibraries_Library> fetchLibrariesResponse_libraries = new List<FetchLibrariesResponse.FetchLibraries_Library>();
			for (int i = 0; i < context.Length("FetchLibraries.Libraries.Length"); i++) {
				FetchLibrariesResponse.FetchLibraries_Library library = new FetchLibrariesResponse.FetchLibraries_Library();
				library.LibraryId = context.StringValue("FetchLibraries.Libraries["+ i +"].LibraryId");
				library.Ctime = context.LongValue("FetchLibraries.Libraries["+ i +"].Ctime");

				fetchLibrariesResponse_libraries.Add(library);
			}
			fetchLibrariesResponse.Libraries = fetchLibrariesResponse_libraries;
        
			return fetchLibrariesResponse;
        }
    }
}