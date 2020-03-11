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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class TranslateCertificateResponseUnmarshaller
    {
        public static TranslateCertificateResponse Unmarshall(UnmarshallerContext context)
        {
			TranslateCertificateResponse translateCertificateResponse = new TranslateCertificateResponse();

			translateCertificateResponse.HttpResponse = context.HttpResponse;
			translateCertificateResponse.RequestId = context.StringValue("TranslateCertificate.RequestId");

			TranslateCertificateResponse.TranslateCertificate_Data data = new TranslateCertificateResponse.TranslateCertificate_Data();

			List<TranslateCertificateResponse.TranslateCertificate_Data.TranslateCertificate_CertificateTranslateItemDTO> data_translatedValues = new List<TranslateCertificateResponse.TranslateCertificate_Data.TranslateCertificate_CertificateTranslateItemDTO>();
			for (int i = 0; i < context.Length("TranslateCertificate.Data.TranslatedValues.Length"); i++) {
				TranslateCertificateResponse.TranslateCertificate_Data.TranslateCertificate_CertificateTranslateItemDTO certificateTranslateItemDTO = new TranslateCertificateResponse.TranslateCertificate_Data.TranslateCertificate_CertificateTranslateItemDTO();
				certificateTranslateItemDTO.Key = context.StringValue("TranslateCertificate.Data.TranslatedValues["+ i +"].Key");
				certificateTranslateItemDTO._Value = context.StringValue("TranslateCertificate.Data.TranslatedValues["+ i +"].Value");
				certificateTranslateItemDTO.ValueTranslation = context.StringValue("TranslateCertificate.Data.TranslatedValues["+ i +"].ValueTranslation");
				certificateTranslateItemDTO.KeyTranslation = context.StringValue("TranslateCertificate.Data.TranslatedValues["+ i +"].KeyTranslation");

				data_translatedValues.Add(certificateTranslateItemDTO);
			}
			data.TranslatedValues = data_translatedValues;
			translateCertificateResponse.Data = data;
        
			return translateCertificateResponse;
        }
    }
}
