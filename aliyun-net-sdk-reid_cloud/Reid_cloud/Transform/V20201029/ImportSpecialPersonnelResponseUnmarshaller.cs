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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ImportSpecialPersonnelResponseUnmarshaller
    {
        public static ImportSpecialPersonnelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImportSpecialPersonnelResponse importSpecialPersonnelResponse = new ImportSpecialPersonnelResponse();

			importSpecialPersonnelResponse.HttpResponse = _ctx.HttpResponse;
			importSpecialPersonnelResponse.Message = _ctx.StringValue("ImportSpecialPersonnel.Message");
			importSpecialPersonnelResponse.RequestId = _ctx.StringValue("ImportSpecialPersonnel.RequestId");
			importSpecialPersonnelResponse.DynamicCode = _ctx.StringValue("ImportSpecialPersonnel.DynamicCode");
			importSpecialPersonnelResponse.DynamicMessage = _ctx.StringValue("ImportSpecialPersonnel.DynamicMessage");
			importSpecialPersonnelResponse.ErrorCode = _ctx.StringValue("ImportSpecialPersonnel.ErrorCode");
			importSpecialPersonnelResponse.ErrorMessage = _ctx.StringValue("ImportSpecialPersonnel.ErrorMessage");
			importSpecialPersonnelResponse.Code = _ctx.StringValue("ImportSpecialPersonnel.Code");
			importSpecialPersonnelResponse.Success = _ctx.BooleanValue("ImportSpecialPersonnel.Success");

			List<ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap> importSpecialPersonnelResponse_specialPersonnelMaps = new List<ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap>();
			for (int i = 0; i < _ctx.Length("ImportSpecialPersonnel.SpecialPersonnelMaps.Length"); i++) {
				ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap specialPersonnelMap = new ImportSpecialPersonnelResponse.ImportSpecialPersonnel_SpecialPersonnelMap();
				specialPersonnelMap.StoreId = _ctx.LongValue("ImportSpecialPersonnel.SpecialPersonnelMaps["+ i +"].StoreId");
				specialPersonnelMap.UkId = _ctx.LongValue("ImportSpecialPersonnel.SpecialPersonnelMaps["+ i +"].UkId");

				importSpecialPersonnelResponse_specialPersonnelMaps.Add(specialPersonnelMap);
			}
			importSpecialPersonnelResponse.SpecialPersonnelMaps = importSpecialPersonnelResponse_specialPersonnelMaps;
        
			return importSpecialPersonnelResponse;
        }
    }
}
