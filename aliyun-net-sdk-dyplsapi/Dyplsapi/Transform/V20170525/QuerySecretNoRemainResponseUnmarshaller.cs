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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class QuerySecretNoRemainResponseUnmarshaller
    {
        public static QuerySecretNoRemainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySecretNoRemainResponse querySecretNoRemainResponse = new QuerySecretNoRemainResponse();

			querySecretNoRemainResponse.HttpResponse = _ctx.HttpResponse;
			querySecretNoRemainResponse.Code = _ctx.StringValue("QuerySecretNoRemain.Code");
			querySecretNoRemainResponse.Message = _ctx.StringValue("QuerySecretNoRemain.Message");
			querySecretNoRemainResponse.RequestId = _ctx.StringValue("QuerySecretNoRemain.RequestId");

			QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO secretRemainDTO = new QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO();
			secretRemainDTO.Amount = _ctx.LongValue("QuerySecretNoRemain.SecretRemainDTO.Amount");
			secretRemainDTO.City = _ctx.StringValue("QuerySecretNoRemain.SecretRemainDTO.City");

			List<QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO.QuerySecretNoRemain_RemainDTO> secretRemainDTO_remainDTOList = new List<QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO.QuerySecretNoRemain_RemainDTO>();
			for (int i = 0; i < _ctx.Length("QuerySecretNoRemain.SecretRemainDTO.RemainDTOList.Length"); i++) {
				QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO.QuerySecretNoRemain_RemainDTO remainDTO = new QuerySecretNoRemainResponse.QuerySecretNoRemain_SecretRemainDTO.QuerySecretNoRemain_RemainDTO();
				remainDTO.Amount = _ctx.LongValue("QuerySecretNoRemain.SecretRemainDTO.RemainDTOList["+ i +"].Amount");
				remainDTO.City = _ctx.StringValue("QuerySecretNoRemain.SecretRemainDTO.RemainDTOList["+ i +"].City");

				secretRemainDTO_remainDTOList.Add(remainDTO);
			}
			secretRemainDTO.RemainDTOList = secretRemainDTO_remainDTOList;
			querySecretNoRemainResponse.SecretRemainDTO = secretRemainDTO;
        
			return querySecretNoRemainResponse;
        }
    }
}
