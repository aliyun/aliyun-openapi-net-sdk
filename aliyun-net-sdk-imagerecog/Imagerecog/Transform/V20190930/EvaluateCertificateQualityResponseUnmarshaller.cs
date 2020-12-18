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
using Aliyun.Acs.imagerecog.Model.V20190930;

namespace Aliyun.Acs.imagerecog.Transform.V20190930
{
    public class EvaluateCertificateQualityResponseUnmarshaller
    {
        public static EvaluateCertificateQualityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			EvaluateCertificateQualityResponse evaluateCertificateQualityResponse = new EvaluateCertificateQualityResponse();

			evaluateCertificateQualityResponse.HttpResponse = _ctx.HttpResponse;
			evaluateCertificateQualityResponse.RequestId = _ctx.StringValue("EvaluateCertificateQuality.RequestId");

			EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data data = new EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data();

			List<EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data.EvaluateCertificateQuality_Element> data_elements = new List<EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data.EvaluateCertificateQuality_Element>();
			for (int i = 0; i < _ctx.Length("EvaluateCertificateQuality.Data.Elements.Length"); i++) {
				EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data.EvaluateCertificateQuality_Element element = new EvaluateCertificateQualityResponse.EvaluateCertificateQuality_Data.EvaluateCertificateQuality_Element();
				element._Value = _ctx.StringValue("EvaluateCertificateQuality.Data.Elements["+ i +"].Value");
				element.Pass = _ctx.StringValue("EvaluateCertificateQuality.Data.Elements["+ i +"].Pass");
				element.Score = _ctx.StringValue("EvaluateCertificateQuality.Data.Elements["+ i +"].Score");

				data_elements.Add(element);
			}
			data.Elements = data_elements;
			evaluateCertificateQualityResponse.Data = data;
        
			return evaluateCertificateQualityResponse;
        }
    }
}
