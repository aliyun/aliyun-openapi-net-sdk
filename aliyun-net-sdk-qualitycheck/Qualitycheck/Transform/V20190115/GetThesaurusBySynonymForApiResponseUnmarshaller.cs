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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetThesaurusBySynonymForApiResponseUnmarshaller
    {
        public static GetThesaurusBySynonymForApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetThesaurusBySynonymForApiResponse getThesaurusBySynonymForApiResponse = new GetThesaurusBySynonymForApiResponse();

			getThesaurusBySynonymForApiResponse.HttpResponse = _ctx.HttpResponse;
			getThesaurusBySynonymForApiResponse.RequestId = _ctx.StringValue("GetThesaurusBySynonymForApi.RequestId");
			getThesaurusBySynonymForApiResponse.Success = _ctx.BooleanValue("GetThesaurusBySynonymForApi.Success");
			getThesaurusBySynonymForApiResponse.Code = _ctx.StringValue("GetThesaurusBySynonymForApi.Code");
			getThesaurusBySynonymForApiResponse.Message = _ctx.StringValue("GetThesaurusBySynonymForApi.Message");

			List<GetThesaurusBySynonymForApiResponse.GetThesaurusBySynonymForApi_ThesaurusPo> getThesaurusBySynonymForApiResponse_data = new List<GetThesaurusBySynonymForApiResponse.GetThesaurusBySynonymForApi_ThesaurusPo>();
			for (int i = 0; i < _ctx.Length("GetThesaurusBySynonymForApi.Data.Length"); i++) {
				GetThesaurusBySynonymForApiResponse.GetThesaurusBySynonymForApi_ThesaurusPo thesaurusPo = new GetThesaurusBySynonymForApiResponse.GetThesaurusBySynonymForApi_ThesaurusPo();
				thesaurusPo.Id = _ctx.LongValue("GetThesaurusBySynonymForApi.Data["+ i +"].Id");
				thesaurusPo.Business = _ctx.StringValue("GetThesaurusBySynonymForApi.Data["+ i +"].Business");

				List<string> thesaurusPo_synonymList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetThesaurusBySynonymForApi.Data["+ i +"].SynonymList.Length"); j++) {
					thesaurusPo_synonymList.Add(_ctx.StringValue("GetThesaurusBySynonymForApi.Data["+ i +"].SynonymList["+ j +"]"));
				}
				thesaurusPo.SynonymList = thesaurusPo_synonymList;

				getThesaurusBySynonymForApiResponse_data.Add(thesaurusPo);
			}
			getThesaurusBySynonymForApiResponse.Data = getThesaurusBySynonymForApiResponse_data;
        
			return getThesaurusBySynonymForApiResponse;
        }
    }
}
