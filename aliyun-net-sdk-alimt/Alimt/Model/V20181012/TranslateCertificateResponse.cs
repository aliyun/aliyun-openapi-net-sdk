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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.alimt.Model.V20181012
{
	public class TranslateCertificateResponse : AcsResponse
	{

		private string requestId;

		private TranslateCertificate_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public TranslateCertificate_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class TranslateCertificate_Data
		{

			private List<TranslateCertificate_CertificateTranslateItemDTO> translatedValues;

			public List<TranslateCertificate_CertificateTranslateItemDTO> TranslatedValues
			{
				get
				{
					return translatedValues;
				}
				set	
				{
					translatedValues = value;
				}
			}

			public class TranslateCertificate_CertificateTranslateItemDTO
			{

				private string keyTranslation;

				private string key;

				private string _value;

				private string valueTranslation;

				public string KeyTranslation
				{
					get
					{
						return keyTranslation;
					}
					set	
					{
						keyTranslation = value;
					}
				}

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}

				public string ValueTranslation
				{
					get
					{
						return valueTranslation;
					}
					set	
					{
						valueTranslation = value;
					}
				}
			}
		}
	}
}
