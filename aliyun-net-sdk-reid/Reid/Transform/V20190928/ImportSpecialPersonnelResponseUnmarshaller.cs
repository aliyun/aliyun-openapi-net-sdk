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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ImportSpecialPersonnelResponseUnmarshaller
    {
        public static ImportSpecialPersonnelResponse Unmarshall(UnmarshallerContext context)
        {
			ImportSpecialPersonnelResponse importSpecialPersonnelResponse = new ImportSpecialPersonnelResponse();

			importSpecialPersonnelResponse.HttpResponse = context.HttpResponse;
			importSpecialPersonnelResponse.ErrorCode = context.StringValue("ImportSpecialPersonnel.ErrorCode");
			importSpecialPersonnelResponse.ErrorMessage = context.StringValue("ImportSpecialPersonnel.ErrorMessage");
			importSpecialPersonnelResponse.RequestId = context.StringValue("ImportSpecialPersonnel.RequestId");
			importSpecialPersonnelResponse.Success = context.BooleanValue("ImportSpecialPersonnel.Success");

			List<ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap> importSpecialPersonnelResponse_specialPersonnelMaps = new List<ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap>();
			for (int i = 0; i < context.Length("ImportSpecialPersonnel.SpecialPersonnelMaps.Length"); i++) {
				ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap specialPersonnelMap = new ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap();
				specialPersonnelMap.UkId = context.LongValue("ImportSpecialPersonnel.SpecialPersonnelMaps["+ i +"].UkId");
				specialPersonnelMap.StoreId = context.LongValue("ImportSpecialPersonnel.SpecialPersonnelMaps["+ i +"].StoreId");

				importSpecialPersonnelResponse_specialPersonnelMaps.Add(specialPersonnelMap);
			}
			importSpecialPersonnelResponse.SpecialPersonnelMaps = importSpecialPersonnelResponse_specialPersonnelMaps;
        
			return importSpecialPersonnelResponse;
        }
    }
}
