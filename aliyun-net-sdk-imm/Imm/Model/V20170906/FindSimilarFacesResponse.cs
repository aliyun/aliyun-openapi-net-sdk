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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class FindSimilarFacesResponse : AcsResponse
	{

		private string requestId;

		private List<FindSimilarFaces_FacesItem> faces;

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

		public List<FindSimilarFaces_FacesItem> Faces
		{
			get
			{
				return faces;
			}
			set	
			{
				faces = value;
			}
		}

		public class FindSimilarFaces_FacesItem
		{

			private string faceId;

			private string imageUri;

			private float? similarity;

			private string externalId;

			private List<FindSimilarFaces_SimilarFacesItem> similarFaces;

			private FindSimilarFaces_FaceAttributes faceAttributes;

			public string FaceId
			{
				get
				{
					return faceId;
				}
				set	
				{
					faceId = value;
				}
			}

			public string ImageUri
			{
				get
				{
					return imageUri;
				}
				set	
				{
					imageUri = value;
				}
			}

			public float? Similarity
			{
				get
				{
					return similarity;
				}
				set	
				{
					similarity = value;
				}
			}

			public string ExternalId
			{
				get
				{
					return externalId;
				}
				set	
				{
					externalId = value;
				}
			}

			public List<FindSimilarFaces_SimilarFacesItem> SimilarFaces
			{
				get
				{
					return similarFaces;
				}
				set	
				{
					similarFaces = value;
				}
			}

			public FindSimilarFaces_FaceAttributes FaceAttributes
			{
				get
				{
					return faceAttributes;
				}
				set	
				{
					faceAttributes = value;
				}
			}

			public class FindSimilarFaces_SimilarFacesItem
			{

				private string faceId;

				private string imageUri;

				private float? similarity;

				private string externalId;

				private FindSimilarFaces_FaceAttributes1 faceAttributes1;

				public string FaceId
				{
					get
					{
						return faceId;
					}
					set	
					{
						faceId = value;
					}
				}

				public string ImageUri
				{
					get
					{
						return imageUri;
					}
					set	
					{
						imageUri = value;
					}
				}

				public float? Similarity
				{
					get
					{
						return similarity;
					}
					set	
					{
						similarity = value;
					}
				}

				public string ExternalId
				{
					get
					{
						return externalId;
					}
					set	
					{
						externalId = value;
					}
				}

				public FindSimilarFaces_FaceAttributes1 FaceAttributes1
				{
					get
					{
						return faceAttributes1;
					}
					set	
					{
						faceAttributes1 = value;
					}
				}

				public class FindSimilarFaces_FaceAttributes1
				{

					private FindSimilarFaces_FaceBoundary faceBoundary;

					public FindSimilarFaces_FaceBoundary FaceBoundary
					{
						get
						{
							return faceBoundary;
						}
						set	
						{
							faceBoundary = value;
						}
					}

					public class FindSimilarFaces_FaceBoundary
					{

						private int? left;

						private int? top;

						private int? width;

						private int? height;

						public int? Left
						{
							get
							{
								return left;
							}
							set	
							{
								left = value;
							}
						}

						public int? Top
						{
							get
							{
								return top;
							}
							set	
							{
								top = value;
							}
						}

						public int? Width
						{
							get
							{
								return width;
							}
							set	
							{
								width = value;
							}
						}

						public int? Height
						{
							get
							{
								return height;
							}
							set	
							{
								height = value;
							}
						}
					}
				}
			}

			public class FindSimilarFaces_FaceAttributes
			{

				private FindSimilarFaces_FaceBoundary2 faceBoundary2;

				public FindSimilarFaces_FaceBoundary2 FaceBoundary2
				{
					get
					{
						return faceBoundary2;
					}
					set	
					{
						faceBoundary2 = value;
					}
				}

				public class FindSimilarFaces_FaceBoundary2
				{

					private int? left;

					private int? top;

					private int? width;

					private int? height;

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}
				}
			}
		}
	}
}
