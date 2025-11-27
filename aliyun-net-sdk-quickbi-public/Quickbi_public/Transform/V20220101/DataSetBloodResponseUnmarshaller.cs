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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class DataSetBloodResponseUnmarshaller
    {
        public static DataSetBloodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DataSetBloodResponse dataSetBloodResponse = new DataSetBloodResponse();

			dataSetBloodResponse.HttpResponse = _ctx.HttpResponse;
			dataSetBloodResponse.RequestId = _ctx.StringValue("DataSetBlood.RequestId");
			dataSetBloodResponse.Success = _ctx.BooleanValue("DataSetBlood.Success");

			List<DataSetBloodResponse.DataSetBlood_WorksModels> dataSetBloodResponse_result = new List<DataSetBloodResponse.DataSetBlood_WorksModels>();
			for (int i = 0; i < _ctx.Length("DataSetBlood.Result.Length"); i++) {
				DataSetBloodResponse.DataSetBlood_WorksModels worksModels = new DataSetBloodResponse.DataSetBlood_WorksModels();
				worksModels.WorksId = _ctx.StringValue("DataSetBlood.Result["+ i +"].WorksId");
				worksModels.WorksType = _ctx.StringValue("DataSetBlood.Result["+ i +"].WorksType");

				dataSetBloodResponse_result.Add(worksModels);
			}
			dataSetBloodResponse.Result = dataSetBloodResponse_result;
        
			return dataSetBloodResponse;
        }
    }
}
